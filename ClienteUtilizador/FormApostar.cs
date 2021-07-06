using Grpc.Core;
using Grpc.Net.Client;
using SDServidor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteUtilizador
{
    public partial class FormApostar : Form
    {
        private string nomeutilizador;
        private GrpcChannel channel;
        public FormApostar(string _nome, GrpcChannel _channel)
        {
            InitializeComponent();
            nomeutilizador = _nome;
            channel = _channel;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chave = ordenar();
            if (chave == "-1")
            {
                MessageBox.Show("Por favor verifique a chave. Erro foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ApostaM apostaM = new ApostaM { NomeUtilizador = nomeutilizador, Chave = chave, Data = DateTime.Now.ToString() };
                ApostaPedido aposta_pedido = new ApostaPedido { Aposta = apostaM };

                try
                {
                    //chama greeter para estabelecer a conexão entre o cliente e o servidor
                    var cliente = new Greeter.GreeterClient(channel);
                    //resposta que o servidor devolve ao cliente
                    var resposta = cliente.ApostaRegisto(aposta_pedido);
                }
                catch (RpcException)
                {
                    MessageBox.Show("Erro no serviço. Por favor tente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Verificar e ordenar Chave inserida pelo utilizador
        private string ordenar()
        {
            int[] numbers = new int[5];
            int[] stars = new int[2];
            int a = 0;

            List<TextBox> Numeros = new List<TextBox> {
                textBoxNumero1,
                textBoxNumero2,
                textBoxNumero3,
                textBoxNumero4,
                textBoxNumero5
            };

            List<TextBox> Estrelas = new List<TextBox> {
                textBoxEstrela1,
                textBoxEstrela2
            };

            //Converte para INT os números inseridos pelo utilizador (antes era uma string)
            foreach (var numero in Numeros)
            {
                if (!Int32.TryParse(numero.Text, out numbers[a++]))
                    return "-1";
            }
            a = 0;
            foreach (var estrela in Estrelas)
            {
                if (!Int32.TryParse(estrela.Text, out stars[a++]))
                    return "-1";
            }

            //Verifica se os números estão entre 1 e 50
            //Verifica se as estrelas estão entre 1 e 12
            if (numbers.Min() < 1 || numbers.Max() > 50 || stars.Min() < 1 || stars.Max() > 12)
            {
                return "-1";
            }

            //Ordena os números e estrelas da chave
            Array.Sort(numbers);
            Array.Sort(stars);

            //Verifica se os números e as estrelas são diferentes
            for (a = 0; a < numbers.Length - 1; a++)
            {
                if (numbers[a] == numbers[a + 1])
                    return "-1";
            }
            if (stars[0] == stars[1])
                return "-1";

            //Juntar os números e as estrelas numa única string para enviar para o servidor
            string NumerosOrdenados = string.Join(" ", numbers);
            string EstrelasOrdenadas = string.Join(" ", stars);
            string chaveOrdenada = NumerosOrdenados + " + " + EstrelasOrdenadas;
            return chaveOrdenada;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            try
            {
                var cliente = new Greeter.GreeterClient(channel);
                var resposta = cliente.ApostaLista(new ApostaListaPedido { NomeUtilizador = "" });
                foreach (var aposta in resposta.Aposta)
                {
                    listView1.Items.Add(new ListViewItem(new[]
                    {
                        aposta.NomeUtilizador, aposta.Chave, aposta.Data
                    }));
                }
            }
            catch (RpcException)
            {
                MessageBox.Show("Erro no serviço gRPC.", "Erro no serviço gRPC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
