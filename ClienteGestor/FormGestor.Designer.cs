
namespace ClienteGestor
{
    partial class FormGestor
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderNome = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderChave = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderData = new System.Windows.Forms.ColumnHeader();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEstrela2 = new System.Windows.Forms.TextBox();
            this.textBoxEstrela1 = new System.Windows.Forms.TextBox();
            this.textBoxNumero5 = new System.Windows.Forms.TextBox();
            this.textBoxNumero4 = new System.Windows.Forms.TextBox();
            this.textBoxNumero3 = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome,
            this.columnHeaderChave,
            this.columnHeaderData});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(182, 13);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(615, 442);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 200;
            // 
            // columnHeaderChave
            // 
            this.columnHeaderChave.Text = "Chave";
            this.columnHeaderChave.Width = 200;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.Width = 200;
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.Location = new System.Drawing.Point(11, 274);
            this.buttonRegistar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(165, 31);
            this.buttonRegistar.TabIndex = 32;
            this.buttonRegistar.Text = "Registar";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Estrelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Números";
            // 
            // textBoxEstrela2
            // 
            this.textBoxEstrela2.Location = new System.Drawing.Point(46, 228);
            this.textBoxEstrela2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEstrela2.Name = "textBoxEstrela2";
            this.textBoxEstrela2.Size = new System.Drawing.Size(27, 27);
            this.textBoxEstrela2.TabIndex = 29;
            // 
            // textBoxEstrela1
            // 
            this.textBoxEstrela1.Location = new System.Drawing.Point(11, 228);
            this.textBoxEstrela1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEstrela1.Name = "textBoxEstrela1";
            this.textBoxEstrela1.Size = new System.Drawing.Size(27, 27);
            this.textBoxEstrela1.TabIndex = 28;
            // 
            // textBoxNumero5
            // 
            this.textBoxNumero5.Location = new System.Drawing.Point(149, 167);
            this.textBoxNumero5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumero5.Name = "textBoxNumero5";
            this.textBoxNumero5.Size = new System.Drawing.Size(27, 27);
            this.textBoxNumero5.TabIndex = 27;
            // 
            // textBoxNumero4
            // 
            this.textBoxNumero4.Location = new System.Drawing.Point(115, 167);
            this.textBoxNumero4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumero4.Name = "textBoxNumero4";
            this.textBoxNumero4.Size = new System.Drawing.Size(27, 27);
            this.textBoxNumero4.TabIndex = 26;
            // 
            // textBoxNumero3
            // 
            this.textBoxNumero3.Location = new System.Drawing.Point(81, 167);
            this.textBoxNumero3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumero3.Name = "textBoxNumero3";
            this.textBoxNumero3.Size = new System.Drawing.Size(27, 27);
            this.textBoxNumero3.TabIndex = 25;
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.Location = new System.Drawing.Point(46, 167);
            this.textBoxNumero2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(27, 27);
            this.textBoxNumero2.TabIndex = 24;
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.Location = new System.Drawing.Point(12, 167);
            this.textBoxNumero1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(27, 27);
            this.textBoxNumero1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 313);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 31);
            this.button1.TabIndex = 34;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonRegistar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEstrela2);
            this.Controls.Add(this.textBoxEstrela1);
            this.Controls.Add(this.textBoxNumero5);
            this.Controls.Add(this.textBoxNumero4);
            this.Controls.Add(this.textBoxNumero3);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Name = "FormGestor";
            this.Text = "Gestor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderChave;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.Button buttonRegistar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEstrela2;
        private System.Windows.Forms.TextBox textBoxEstrela1;
        private System.Windows.Forms.TextBox textBoxNumero5;
        private System.Windows.Forms.TextBox textBoxNumero4;
        private System.Windows.Forms.TextBox textBoxNumero3;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.Button button1;
    }
}

