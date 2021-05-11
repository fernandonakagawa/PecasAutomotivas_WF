
namespace AtividadePecas
{
    partial class Form1
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
            this.lvPecas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.lbPeca = new System.Windows.Forms.Label();
            this.cbCarro = new System.Windows.Forms.ComboBox();
            this.gbCarro = new System.Windows.Forms.GroupBox();
            this.btCarroAdicionar = new System.Windows.Forms.Button();
            this.ndAno = new System.Windows.Forms.NumericUpDown();
            this.tbCarroNome = new System.Windows.Forms.TextBox();
            this.tbCarroMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPeca = new System.Windows.Forms.GroupBox();
            this.tbPecaModelo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btPecaAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ndPecaValor = new System.Windows.Forms.NumericUpDown();
            this.tbPecaNome = new System.Windows.Forms.TextBox();
            this.tbPecaMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btDeletar = new System.Windows.Forms.Button();
            this.gbCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndAno)).BeginInit();
            this.gbPeca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndPecaValor)).BeginInit();
            this.SuspendLayout();
            // 
            // lvPecas
            // 
            this.lvPecas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPecas.HideSelection = false;
            this.lvPecas.Location = new System.Drawing.Point(367, 35);
            this.lvPecas.Name = "lvPecas";
            this.lvPecas.Size = new System.Drawing.Size(366, 304);
            this.lvPecas.TabIndex = 0;
            this.lvPecas.UseCompatibleStateImageBehavior = false;
            this.lvPecas.View = System.Windows.Forms.View.Details;
            this.lvPecas.SelectedIndexChanged += new System.EventHandler(this.lvPecas_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marca";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Modelo";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valor";
            // 
            // lbPeca
            // 
            this.lbPeca.AutoSize = true;
            this.lbPeca.Location = new System.Drawing.Point(367, 13);
            this.lbPeca.Name = "lbPeca";
            this.lbPeca.Size = new System.Drawing.Size(40, 15);
            this.lbPeca.TabIndex = 1;
            this.lbPeca.Text = "Peças:";
            // 
            // cbCarro
            // 
            this.cbCarro.FormattingEnabled = true;
            this.cbCarro.Location = new System.Drawing.Point(67, 22);
            this.cbCarro.Name = "cbCarro";
            this.cbCarro.Size = new System.Drawing.Size(195, 23);
            this.cbCarro.TabIndex = 2;
            this.cbCarro.SelectedIndexChanged += new System.EventHandler(this.cbCarro_SelectedIndexChanged);
            // 
            // gbCarro
            // 
            this.gbCarro.Controls.Add(this.btCarroAdicionar);
            this.gbCarro.Controls.Add(this.ndAno);
            this.gbCarro.Controls.Add(this.tbCarroNome);
            this.gbCarro.Controls.Add(this.tbCarroMarca);
            this.gbCarro.Controls.Add(this.label3);
            this.gbCarro.Controls.Add(this.label1);
            this.gbCarro.Controls.Add(this.label2);
            this.gbCarro.Location = new System.Drawing.Point(13, 35);
            this.gbCarro.Name = "gbCarro";
            this.gbCarro.Size = new System.Drawing.Size(348, 109);
            this.gbCarro.TabIndex = 3;
            this.gbCarro.TabStop = false;
            this.gbCarro.Text = "Cadastrar Carro";
            // 
            // btCarroAdicionar
            // 
            this.btCarroAdicionar.Location = new System.Drawing.Point(268, 22);
            this.btCarroAdicionar.Name = "btCarroAdicionar";
            this.btCarroAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btCarroAdicionar.TabIndex = 6;
            this.btCarroAdicionar.Text = "Adicionar";
            this.btCarroAdicionar.UseVisualStyleBackColor = true;
            this.btCarroAdicionar.Click += new System.EventHandler(this.btCarroAdicionar_Click);
            // 
            // ndAno
            // 
            this.ndAno.Location = new System.Drawing.Point(67, 80);
            this.ndAno.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.ndAno.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.ndAno.Name = "ndAno";
            this.ndAno.Size = new System.Drawing.Size(77, 23);
            this.ndAno.TabIndex = 5;
            this.ndAno.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // tbCarroNome
            // 
            this.tbCarroNome.Location = new System.Drawing.Point(67, 51);
            this.tbCarroNome.MaxLength = 32;
            this.tbCarroNome.Name = "tbCarroNome";
            this.tbCarroNome.Size = new System.Drawing.Size(195, 23);
            this.tbCarroNome.TabIndex = 4;
            // 
            // tbCarroMarca
            // 
            this.tbCarroMarca.Location = new System.Drawing.Point(67, 22);
            this.tbCarroMarca.MaxLength = 32;
            this.tbCarroMarca.Name = "tbCarroMarca";
            this.tbCarroMarca.Size = new System.Drawing.Size(195, 23);
            this.tbCarroMarca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marca:";
            // 
            // gbPeca
            // 
            this.gbPeca.Controls.Add(this.btDeletar);
            this.gbPeca.Controls.Add(this.tbPecaModelo);
            this.gbPeca.Controls.Add(this.label8);
            this.gbPeca.Controls.Add(this.btPecaAdicionar);
            this.gbPeca.Controls.Add(this.label4);
            this.gbPeca.Controls.Add(this.ndPecaValor);
            this.gbPeca.Controls.Add(this.cbCarro);
            this.gbPeca.Controls.Add(this.tbPecaNome);
            this.gbPeca.Controls.Add(this.tbPecaMarca);
            this.gbPeca.Controls.Add(this.label7);
            this.gbPeca.Controls.Add(this.label5);
            this.gbPeca.Controls.Add(this.label6);
            this.gbPeca.Location = new System.Drawing.Point(13, 151);
            this.gbPeca.Name = "gbPeca";
            this.gbPeca.Size = new System.Drawing.Size(348, 188);
            this.gbPeca.TabIndex = 4;
            this.gbPeca.TabStop = false;
            this.gbPeca.Text = "Cadastrar Peça";
            // 
            // tbPecaModelo
            // 
            this.tbPecaModelo.Location = new System.Drawing.Point(67, 114);
            this.tbPecaModelo.MaxLength = 32;
            this.tbPecaModelo.Name = "tbPecaModelo";
            this.tbPecaModelo.Size = new System.Drawing.Size(195, 23);
            this.tbPecaModelo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Modelo:";
            // 
            // btPecaAdicionar
            // 
            this.btPecaAdicionar.Location = new System.Drawing.Point(268, 56);
            this.btPecaAdicionar.Name = "btPecaAdicionar";
            this.btPecaAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btPecaAdicionar.TabIndex = 13;
            this.btPecaAdicionar.Text = "Adicionar";
            this.btPecaAdicionar.UseVisualStyleBackColor = true;
            this.btPecaAdicionar.Click += new System.EventHandler(this.btPecaAdicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carro:";
            // 
            // ndPecaValor
            // 
            this.ndPecaValor.DecimalPlaces = 2;
            this.ndPecaValor.Location = new System.Drawing.Point(67, 143);
            this.ndPecaValor.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ndPecaValor.Name = "ndPecaValor";
            this.ndPecaValor.Size = new System.Drawing.Size(195, 23);
            this.ndPecaValor.TabIndex = 12;
            // 
            // tbPecaNome
            // 
            this.tbPecaNome.Location = new System.Drawing.Point(67, 85);
            this.tbPecaNome.MaxLength = 32;
            this.tbPecaNome.Name = "tbPecaNome";
            this.tbPecaNome.Size = new System.Drawing.Size(195, 23);
            this.tbPecaNome.TabIndex = 11;
            // 
            // tbPecaMarca
            // 
            this.tbPecaMarca.Location = new System.Drawing.Point(67, 56);
            this.tbPecaMarca.MaxLength = 32;
            this.tbPecaMarca.Name = "tbPecaMarca";
            this.tbPecaMarca.Size = new System.Drawing.Size(195, 23);
            this.tbPecaMarca.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nome:";
            // 
            // btDeletar
            // 
            this.btDeletar.Enabled = false;
            this.btDeletar.Location = new System.Drawing.Point(268, 88);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 16;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 351);
            this.Controls.Add(this.gbPeca);
            this.Controls.Add(this.gbCarro);
            this.Controls.Add(this.lbPeca);
            this.Controls.Add(this.lvPecas);
            this.Name = "Form1";
            this.Text = "Catálogo de Peças";
            this.gbCarro.ResumeLayout(false);
            this.gbCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndAno)).EndInit();
            this.gbPeca.ResumeLayout(false);
            this.gbPeca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndPecaValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPecas;
        private System.Windows.Forms.Label lbPeca;
        private System.Windows.Forms.ComboBox cbCarro;
        private System.Windows.Forms.GroupBox gbCarro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPeca;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbCarro;
        private System.Windows.Forms.TextBox tbCarroMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCarroAdicionar;
        private System.Windows.Forms.NumericUpDown ndAno;
        private System.Windows.Forms.TextBox tbCarroNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPecaModelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btPecaAdicionar;
        private System.Windows.Forms.NumericUpDown ndPecaValor;
        private System.Windows.Forms.TextBox tbPecaNome;
        private System.Windows.Forms.TextBox tbPecaMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btDeletar;
    }
}

