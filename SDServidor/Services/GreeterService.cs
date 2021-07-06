using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SDServidor.Data;
using SDServidor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDServidor
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        private readonly SDServidorContext _db;
        public GreeterService(ILogger<GreeterService> logger, SDServidorContext db)
        {
            _logger = logger;
            _db = db;
        }

        public override async Task<Resposta> ApostaRegisto(ApostaPedido pedido, ServerCallContext context)
        {
            //Verifica se j� existe algum utilizador com esse nome
            var utilizador = _db.ModelUtilizadors.FirstOrDefault(x => x.Nome == pedido.Aposta.NomeUtilizador);
            if (utilizador == null) //Se n�o existir, cria um novo Utilizador e adiciona � base de dados
            {
                utilizador = new ModelUtilizador { Nome = pedido.Aposta.NomeUtilizador };
                _db.Add(utilizador);
            }
            //Cria uma nova aposta e adiciona � base de dados
            ModelApostum aposta = new ModelApostum
            {
                Chave = pedido.Aposta.Chave,
                Data = pedido.Aposta.Data,
                Registada = false,
                Utilizador = utilizador
            };
            _db.Add(aposta);

            //Tenta guardar as altera��es na base de dados e responder ao cliente 
            try
            {
                await _db.SaveChangesAsync();
                //para escrever na consola do servidor, para este saber o que se est� a passar. Para informar a consola de servidor.
                //Sem esta linha c�digo, a aplica��o continuar a correr na mesma, mas n�o informa o servidor do que est� a acontecer.
                _logger.LogInformation("Utilizador {0} chave registada: {1}", utilizador.Nome, aposta.Chave);
                return await Task.FromResult(new Resposta { Sucesso = true });
            }
            catch (DbUpdateException e)
            {
                _logger.LogError(e, "Erro na atualiza��o da database - GreeterService.cs: ApostaRegisto");
                return await Task.FromResult(new Resposta { Sucesso = false });
            }
        }

        //Atender ao pedido ApostaLista dos clientes para Utilizador e Administrador
        public override async Task<ListaA> ApostaLista(ApostaListaPedido pedido, ServerCallContext context)
        {
            List<ApostaM> listaApostas = new List<ApostaM>();
            List<ModelApostum> apostasL = new List<ModelApostum>();

            // Se o nome enviado pelo cliente for vazio, quer dizer que foi enviado 
            //pelo Cliente Administrador, ou seja pede todas as apostas
            if (pedido.NomeUtilizador == "")
            {
                apostasL = await _db.ModelAposta.Include(b => b.Utilizador).Where(x => x.Registada == false && x.Utilizador.Nome != "Vencedora")
                                                .OrderByDescending(x => x.Data).ToListAsync();
            }
            foreach (var a in apostasL)
            {
                var aposta = new ApostaM { NomeUtilizador = a.Utilizador.Nome, Chave = a.Chave, Data = a.Data };
                listaApostas.Add(aposta);
            }
            _logger.LogInformation("Admintrador pediu a lista de apostas. {0} apostas foram retornadas.", apostasL.Count());
            return await Task.FromResult(new ListaA { Aposta = { listaApostas } });
        }

        // Atender ao pedido Listar Utilizadores do Cliente Administrador
        public override async Task<ListaU> UtilizadorLista(ListaUtilizadorPedido pedido, ServerCallContext context)
        {
            ListaU utilizadorLista = new ListaU();

            // guardar numa lista utilizadores cujo nome n�o � "Vencedora" (Aposta vencedora)
            // e cujas apostas n�o estejam arquivadas
            var utilizadores = await _db.ModelAposta.Include(b => b.Utilizador).Where(x => x.Registada == false && x.Utilizador.Nome != "Vencedora")
                                                    .Select(a => a.Utilizador.Nome).Distinct().ToListAsync();

            foreach (var u in utilizadores)
            {
                utilizadorLista.Utilizadores.Add(u);
            }

            _logger.LogInformation("Administrador pediu os utilizadores registados no sistema. {0} utilizadores retornados.", utilizadores.Count());
            return await Task.FromResult(utilizadorLista);
        }

        // Atender ao pedido Arquivar Apostas do Cliente Administrador
        public override async Task<Resposta> ApostaGuadar(PedidoGuardar pedido, ServerCallContext context)
        {
            // Procurar todas as apostas que n�o est�o arquivadas e alterar a coluna Arquivada
            var apostasADecorrer = _db.ModelAposta.Where(x => x.Registada == false).ToList();
            foreach (var apostas in apostasADecorrer)
            {
                apostas.Registada = true;
            }

            try
            {
                await _db.SaveChangesAsync();
                _logger.LogInformation("Admintrador pediu para guardar as apostas. {0} apostas foram guardadas.", apostasADecorrer.Count());
                return await Task.FromResult(new Resposta { Sucesso = true });
            }
            catch (DbUpdateException e)
            {
                _logger.LogError(e, "Erro na atualiza��o da database -> GreeterService.cs: ApostaGuadar");
                return await Task.FromResult(new Resposta { Sucesso = false });
            }
        }

        // Atender ao pedido de Registo de Chave Vencedora do Cliente Gestor
        public override async Task<Resposta> ChaveWinRegisto(ChaveWin pedido, ServerCallContext context)
        {
            // Verificar se j� existe alguma chave Vencedora que n�o esteja arquivada
            var chaveWin = await _db.ModelAposta.Include(x => x.Utilizador).Where(b => b.Registada == false).AnyAsync(u => u.Utilizador.Nome == "Vencedora");
            if (chaveWin)   // Se j� existir, n�o deixar inserir uma nova
            {
                _logger.LogWarning("Gestor tentou registar a chave vencedora, mas j� existe uma chave vencedora n�o registada.");
                return await Task.FromResult(new Resposta { Sucesso = false });
            }

            // Verificar se j� existe o User "Vencedora", onde ser�o associadas as chaves vencedoras
            // Se ainda n�o existir cria-lo e adicionar � base de dados
            var ChaveWinU = await _db.ModelUtilizadors.FirstOrDefaultAsync(u => u.Nome == "Vencedora");
            if (ChaveWinU == null)
            {
                ChaveWinU = new ModelUtilizador { Nome = "Vencedora" };
                _db.Add(ChaveWinU);
            }

            // Adicionar chave vencedora � base de dados
            var apostaWin = new ModelApostum
            {
                Chave = pedido.ChaveVencedora,
                Data = DateTime.Now.ToString(),
                Registada = false,
                Utilizador = ChaveWinU
            };
            _db.Add(apostaWin);

            try
            {
                await _db.SaveChangesAsync();
                _logger.LogInformation("Gestor registou a aposta vencedora: {0}.", apostaWin.Chave);
                return await Task.FromResult(new Resposta { Sucesso = true });
            }
            catch (DbUpdateException e)
            {
                _logger.LogError(e, "Erro na atualiza��o da database -> GreeterService.cs: ChaveWinRegisto");
                return await Task.FromResult(new Resposta { Sucesso = false });
            }
        }

        // Atender ao pedido de Ver as Apostas Vencedoras do Cliente Gestor
        public override async Task<ListaAWin> ApostaWinLista(ApostaWinPedido pedido, ServerCallContext context)
        {
            // Ver qual � a aposta Vencedora Ativa (User == "Vencedora" e Arquivada == false)
            var apostaWin = await _db.ModelAposta.Include(x => x.Utilizador).Where(b => b.Utilizador.Nome == "Vencedora")
                                                 .FirstOrDefaultAsync(b => b.Registada == false);

            List<ModelApostum> aposta = new List<ModelApostum>();

            // Se existir aposta vencedora, procurar na base de dados todas as
            // apostas em que a chave � igual � da chave vencedora
            if (apostaWin != null)
            {
                aposta = await _db.ModelAposta.Include(x => x.Utilizador).Where(a => a.Registada == false && a.Utilizador.Nome != "Vencedora" && a.Chave == apostaWin.Chave)
                                               .OrderByDescending(x => x.Data).ToListAsync();
            }

            List<ApostaM> apostasL = new List<ApostaM>();
            foreach (var aL in aposta)
            {
                apostasL.Add(new ApostaM { Chave = aL.Chave, Data = aL.Data, NomeUtilizador = aL.Utilizador.Nome });
            }

            _logger.LogInformation("Gestor pediu as chaves vencedoras. {0} chaves retornadas.", apostasL.Count());
            return await Task.FromResult(new ListaAWin { ApostaVencedora = { apostasL } });
        }
    }
}
