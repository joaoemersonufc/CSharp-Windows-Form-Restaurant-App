namespace AssaKabrasa.View
{
    partial class PainelCaixa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbriCaixa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EdtSaldoInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelStatusCaixa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdicionarLan = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelSaldoAtual = new System.Windows.Forms.Label();
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.btnExcluirLan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listCaixa = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listCaixa);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAbriCaixa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EdtSaldoInicial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 566);
            this.panel1.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(32, 482);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 25);
            this.label17.TabIndex = 18;
            this.label17.Text = "00:00:00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(34, 466);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(201, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "Hora do último fechamento :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label15.Location = new System.Drawing.Point(174, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hora de abertura :";
            // 
            // btnAbriCaixa
            // 
            this.btnAbriCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAbriCaixa.Location = new System.Drawing.Point(285, 466);
            this.btnAbriCaixa.Name = "btnAbriCaixa";
            this.btnAbriCaixa.Size = new System.Drawing.Size(98, 35);
            this.btnAbriCaixa.TabIndex = 5;
            this.btnAbriCaixa.Text = "ABRIR";
            this.btnAbriCaixa.UseVisualStyleBackColor = true;
            this.btnAbriCaixa.Click += new System.EventHandler(this.btnAbriCaixa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Observações:";
            // 
            // EdtSaldoInicial
            // 
            this.EdtSaldoInicial.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EdtSaldoInicial.Location = new System.Drawing.Point(35, 119);
            this.EdtSaldoInicial.Name = "EdtSaldoInicial";
            this.EdtSaldoInicial.ReadOnly = true;
            this.EdtSaldoInicial.Size = new System.Drawing.Size(149, 20);
            this.EdtSaldoInicial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(38, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "SALDO INICIAL  (R$)";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelStatusCaixa);
            this.panel3.Location = new System.Drawing.Point(10, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 62);
            this.panel3.TabIndex = 0;
            // 
            // labelStatusCaixa
            // 
            this.labelStatusCaixa.AutoSize = true;
            this.labelStatusCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelStatusCaixa.Location = new System.Drawing.Point(112, 17);
            this.labelStatusCaixa.Name = "labelStatusCaixa";
            this.labelStatusCaixa.Size = new System.Drawing.Size(156, 22);
            this.labelStatusCaixa.TabIndex = 0;
            this.labelStatusCaixa.Text = "CAIXA FECHADO";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnAdicionarLan);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.labelSaldoAtual);
            this.panel2.Controls.Add(this.btnFecharCaixa);
            this.panel2.Controls.Add(this.btnExcluirLan);
            this.panel2.Location = new System.Drawing.Point(421, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 566);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(311, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "SALDO R$: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(184, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnAdicionarLan
            // 
            this.btnAdicionarLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdicionarLan.Location = new System.Drawing.Point(533, 14);
            this.btnAdicionarLan.Name = "btnAdicionarLan";
            this.btnAdicionarLan.Size = new System.Drawing.Size(149, 27);
            this.btnAdicionarLan.TabIndex = 14;
            this.btnAdicionarLan.Text = "+LANÇAMENTO";
            this.btnAdicionarLan.UseVisualStyleBackColor = true;
            this.btnAdicionarLan.Click += new System.EventHandler(this.btnAdicionarLan_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(52, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(220, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "MOVIMENTAÇÃO DO CAIXA";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(55, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(632, 437);
            this.panel4.TabIndex = 9;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataHora,
            this.Descricao,
            this.Entrada,
            this.Saida,
            this.FormPag,
            this.Selecionar});
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.Size = new System.Drawing.Size(627, 435);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // DataHora
            // 
            this.DataHora.HeaderText = "Data/Hora";
            this.DataHora.Name = "DataHora";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            // 
            // Saida
            // 
            this.Saida.HeaderText = "Saida";
            this.Saida.Name = "Saida";
            // 
            // FormPag
            // 
            this.FormPag.HeaderText = "Form. Pag";
            this.FormPag.Name = "FormPag";
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // labelSaldoAtual
            // 
            this.labelSaldoAtual.AutoSize = true;
            this.labelSaldoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoAtual.Location = new System.Drawing.Point(428, 522);
            this.labelSaldoAtual.Name = "labelSaldoAtual";
            this.labelSaldoAtual.Size = new System.Drawing.Size(66, 25);
            this.labelSaldoAtual.TabIndex = 8;
            this.labelSaldoAtual.Text = "00,00";
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFecharCaixa.Location = new System.Drawing.Point(508, 515);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(174, 35);
            this.btnFecharCaixa.TabIndex = 7;
            this.btnFecharCaixa.Text = "FECHAR CAIXA";
            this.btnFecharCaixa.UseVisualStyleBackColor = true;
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // btnExcluirLan
            // 
            this.btnExcluirLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluirLan.Location = new System.Drawing.Point(55, 516);
            this.btnExcluirLan.Name = "btnExcluirLan";
            this.btnExcluirLan.Size = new System.Drawing.Size(100, 35);
            this.btnExcluirLan.TabIndex = 6;
            this.btnExcluirLan.Text = "EXCLUIR";
            this.btnExcluirLan.UseVisualStyleBackColor = true;
            this.btnExcluirLan.Click += new System.EventHandler(this.btnExcluirLan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "DATA/HORA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "DESCRIÇÃO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "ENTRADA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "SAIDA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(564, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "FORM. PAG";
            // 
            // listCaixa
            // 
            this.listCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCaixa.FormattingEnabled = true;
            this.listCaixa.Location = new System.Drawing.Point(35, 220);
            this.listCaixa.Name = "listCaixa";
            this.listCaixa.Size = new System.Drawing.Size(348, 225);
            this.listCaixa.TabIndex = 19;
            // 
            // PainelCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PainelCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROLE DE CAIXA";
            this.Load += new System.EventHandler(this.PainelCaixa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelStatusCaixa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdtSaldoInicial;
        private System.Windows.Forms.Button btnAbriCaixa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFecharCaixa;
        private System.Windows.Forms.Button btnExcluirLan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdicionarLan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormPag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSaldoAtual;
        public System.Windows.Forms.ListBox listCaixa;
    }
}