namespace AssaKabrasa.View
{
    partial class PainelRecuperacao
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
            this.labelEscolha = new System.Windows.Forms.Label();
            this.escolherPergunta = new System.Windows.Forms.ComboBox();
            this.labelResposta = new System.Windows.Forms.Label();
            this.EdtResposta = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelEscolha
            // 
            this.labelEscolha.AutoSize = true;
            this.labelEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEscolha.Location = new System.Drawing.Point(37, 69);
            this.labelEscolha.Name = "labelEscolha";
            this.labelEscolha.Size = new System.Drawing.Size(57, 16);
            this.labelEscolha.TabIndex = 10;
            this.labelEscolha.Text = "Escolha";
            // 
            // escolherPergunta
            // 
            this.escolherPergunta.FormattingEnabled = true;
            this.escolherPergunta.Items.AddRange(new object[] {
            "Qual a cidade que você nasceu?",
            "Como é o nome do seu primeiro animal?",
            "Me diga uma data importante"});
            this.escolherPergunta.Location = new System.Drawing.Point(34, 89);
            this.escolherPergunta.Name = "escolherPergunta";
            this.escolherPergunta.Size = new System.Drawing.Size(488, 21);
            this.escolherPergunta.TabIndex = 9;
            // 
            // labelResposta
            // 
            this.labelResposta.AutoSize = true;
            this.labelResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResposta.Location = new System.Drawing.Point(37, 122);
            this.labelResposta.Name = "labelResposta";
            this.labelResposta.Size = new System.Drawing.Size(67, 16);
            this.labelResposta.TabIndex = 12;
            this.labelResposta.Text = "Resposta";
            // 
            // EdtResposta
            // 
            this.EdtResposta.Location = new System.Drawing.Point(34, 142);
            this.EdtResposta.Name = "EdtResposta";
            this.EdtResposta.Size = new System.Drawing.Size(488, 20);
            this.EdtResposta.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(331, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 47);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(94, 233);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 47);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvarAdm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label1.Location = new System.Drawing.Point(117, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Recuperando com base na sua resposta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Confirmar senha";
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(282, 195);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(241, 20);
            this.txtSenha2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sua nova senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(34, 195);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(218, 20);
            this.txtSenha.TabIndex = 18;
            // 
            // PainelRecuperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 303);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelResposta);
            this.Controls.Add(this.EdtResposta);
            this.Controls.Add(this.labelEscolha);
            this.Controls.Add(this.escolherPergunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PainelRecuperacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperação";
            this.Load += new System.EventHandler(this.PainelRecuperacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEscolha;
        private System.Windows.Forms.ComboBox escolherPergunta;
        private System.Windows.Forms.Label labelResposta;
        private System.Windows.Forms.TextBox EdtResposta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
    }
}