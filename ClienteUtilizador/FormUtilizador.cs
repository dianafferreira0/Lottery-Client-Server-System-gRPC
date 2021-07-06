using Grpc.Core;
using Grpc.Net.Client;
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

namespace ClienteUtilizador
{
    public partial class FormUtilizador : Form
    {
        private GrpcChannel channel;
        public FormUtilizador()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 2 || textBox1.Text.Length < 20)
            {
                Hide();
                using (FormApostar apostarform = new FormApostar(textBox1.Text, channel)) apostarform.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Insira um nome entre 2 a 20 caracteres.", "Erro:Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
