
namespace ClienteUtilizador
{
    partial class FormApostar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.colunaNome = new System.Windows.Forms.ColumnHeader();
            this.colunaChave = new System.Windows.Forms.ColumnHeader();
            this.colunaData = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEstrela2 = new System.Windows.Forms.TextBox();
            this.textBoxEstrela1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumero5 = new System.Windows.Forms.TextBox();
            this.textBoxNumero4 = new System.Windows.Forms.TextBox();
            this.textBoxNumero3 = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaNome,
            this.colunaChave,
            this.colunaData});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(232, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(606, 521);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colunaNome
            // 
            this.colunaNome.Text = "Nome";
            this.colunaNome.Width = 200;
            // 
            // colunaChave
            // 
            this.colunaChave.Text = "Chave";
            this.colunaChave.Width = 200;
            // 
            // colunaData
            // 
            this.colunaData.Text = "Data";
            this.colunaData.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 275);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 34);
            this.button1.TabIndex = 31;
            this.button1.Text = "Apostar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEstrela2
            // 
            this.textBoxEstrela2.Location = new System.Drawing.Point(50, 224);
            this.textBoxEstrela2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEstrela2.Name = "textBoxEstrela2";
            this.textBoxEstrela2.Size = new System.Drawing.Size(31, 27);
            this.textBoxEstrela2.TabIndex = 30;
            // 
            // textBoxEstrela1
            // 
            this.textBoxEstrela1.Location = new System.Drawing.Point(11, 224);
            this.textBoxEstrela1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEstrela1.Name = "textBoxEstrela1";
            this.textBoxEstrela1.Size = new System.Drawing.Size(31, 27);
            this.textBoxEstrela1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Estrelas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Numeros";
            // 
            // textBoxNumero5
            // 
            this.textBoxNumero5.Location = new System.Drawing.Point(167, 150);
            this.textBoxNumero5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumero5.Name = "textBoxNumero5";
            this.textBoxNumero5.Size = new System.Drawing.Size(31, 27);
            this.textBoxNumero5.TabIndex = 26;
            // 
            // textBoxNumero4
            // 
            this.textBoxNumero4.Location = new System.Drawing.Point(128, 150);
            this.textBoxNumero4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumero4.Name = "textBoxNumero4";
            this.textBoxNumero4.Size = new System.Drawing.Size(31, 27);
            this.textBoxNumero4.TabIndex = 25;
            // 
            // textBoxNumero3
            // 
            this.textBoxNumero3.Location = new System.Drawing.Point(89, 150);
            this.textBoxNumero3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumero3.Name = "textBoxNumero3";
            this.textBoxNumero3.Size = new System.Drawing.Size(31, 27);
            this.textBoxNumero3.TabIndex = 24;
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.Location = new System.Drawing.Point(50, 150);
            this.textBoxNumero2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(31, 27);
            this.textBoxNumero2.TabIndex = 23;
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.Location = new System.Drawing.Point(12, 150);
            this.textBoxNumero1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(31, 27);
            this.textBoxNumero1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 317);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 34);
            this.button2.TabIndex = 33;
            this.button2.Text = "Listar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormApostar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 539);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxEstrela2);
            this.Controls.Add(this.textBoxEstrela1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumero5);
            this.Controls.Add(this.textBoxNumero4);
            this.Controls.Add(this.textBoxNumero3);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Name = "FormApostar";
            this.Text = "Apostar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colunaNome;
        private System.Windows.Forms.ColumnHeader colunaChave;
        private System.Windows.Forms.ColumnHeader colunaData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxEstrela2;
        private System.Windows.Forms.TextBox textBoxEstrela1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumero5;
        private System.Windows.Forms.TextBox textBoxNumero4;
        private System.Windows.Forms.TextBox textBoxNumero3;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.Button button2;
    }
}