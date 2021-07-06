
namespace ClienteAdminstrador
{
    partial class FormAdminstrador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonArquivar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewListarApostas = new System.Windows.Forms.ListView();
            this.columnHeaderChave = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderData = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewUtilizadores = new System.Windows.Forms.ListView();
            this.columnHeaderNome = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArquivar
            // 
            this.buttonArquivar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonArquivar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonArquivar.Location = new System.Drawing.Point(274, 453);
            this.buttonArquivar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonArquivar.Name = "buttonArquivar";
            this.buttonArquivar.Size = new System.Drawing.Size(238, 37);
            this.buttonArquivar.TabIndex = 10;
            this.buttonArquivar.Text = "Arquivar";
            this.buttonArquivar.UseVisualStyleBackColor = true;
            this.buttonArquivar.Click += new System.EventHandler(this.buttonArquivar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista de Apostas";
            // 
            // listViewListarApostas
            // 
            this.listViewListarApostas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewListarApostas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderChave,
            this.columnHeader1,
            this.columnHeaderData});
            this.listViewListarApostas.GridLines = true;
            this.listViewListarApostas.HideSelection = false;
            this.listViewListarApostas.Location = new System.Drawing.Point(19, 34);
            this.listViewListarApostas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewListarApostas.Name = "listViewListarApostas";
            this.listViewListarApostas.Size = new System.Drawing.Size(516, 411);
            this.listViewListarApostas.TabIndex = 8;
            this.listViewListarApostas.UseCompatibleStateImageBehavior = false;
            this.listViewListarApostas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderChave
            // 
            this.columnHeaderChave.Text = "Chave";
            this.columnHeaderChave.Width = 170;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 170;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.Width = 170;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista Utilizadores com Apostas";
            // 
            // listViewUtilizadores
            // 
            this.listViewUtilizadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewUtilizadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome});
            this.listViewUtilizadores.GridLines = true;
            this.listViewUtilizadores.HideSelection = false;
            this.listViewUtilizadores.Location = new System.Drawing.Point(541, 34);
            this.listViewUtilizadores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewUtilizadores.Name = "listViewUtilizadores";
            this.listViewUtilizadores.Size = new System.Drawing.Size(225, 411);
            this.listViewUtilizadores.TabIndex = 6;
            this.listViewUtilizadores.UseCompatibleStateImageBehavior = false;
            this.listViewUtilizadores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 220;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(19, 453);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Listar Apostas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(534, 453);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Listar Utilizadores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAdminstrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 502);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonArquivar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewListarApostas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewUtilizadores);
            this.Name = "FormAdminstrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArquivar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewListarApostas;
        private System.Windows.Forms.ColumnHeader columnHeaderChave;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewUtilizadores;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

