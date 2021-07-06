using Grpc.Core;
using Grpc.Net.Client;
using SDServidor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteAdminstrador
{
    public partial class FormAdminstrador : Form
    {
        private GrpcChannel channel;
        public FormAdminstrador()
        {
            InitializeComponent();
            try
            {
                var httpHandler = new HttpClientHandler();
                httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions { HttpHandler = httpHandler });
            }
            catch (RpcException)
            {
                MessageBox.Show("Erro no serviço. Por favor tente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonArquivar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Greeter.GreeterClient(channel);
                var resposta = cliente.ApostaGuadar(new PedidoGuardar());
                if(resposta.Sucesso == true)
                {
                    MessageBox.Show("Apostas arquivadas com sucesso", "Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro. Apostas não foram arquivadas", "Erro");
                }
            }
            catch (RpcException)
            {
                MessageBox.Show("Erro no serviço. Por favor tente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listViewListarApostas.Items.Clear();
            try
            {
                var cliente = new Greeter.GreeterClient(channel);
                var resposta = cliente.ApostaLista(new ApostaListaPedido { NomeUtilizador = "" });

                // Apresentar a lista recebida do servidor
                foreach (var aposta in resposta.Aposta)
                {
                    listViewListarApostas.Items.Add(new ListViewItem(new[]
                    {
                        aposta.Chave, aposta.NomeUtilizador, aposta.Data
                    }));
                }
            }
            catch (RpcException)
            {
                MessageBox.Show("Erro no serviço. Por favor tente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listViewUtilizadores.Items.Clear();
            try
            {
                // enviar nome do utilizador para o servidor
                // no pedido de lista de apostas
                var cliente = new Greeter.GreeterClient(channel);
                var resposta = cliente.UtilizadorLista(new ListaUtilizadorPedido());

                // Apresentar a lista de apostas do utilizador
                foreach (var utilizador in resposta.Utilizadores)
                {
                    listViewUtilizadores.Items.Add(new ListViewItem(new[] { utilizador }));
                }
            }
            catch (RpcException)
            {
                MessageBox.Show("Erro no serviço. Por favor tente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
