namespace AssaKabrasa.View
{
    partial class itemLinhaCaixa
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelItemLinhaCaixa = new System.Windows.Forms.Panel();
            this.checkBoxItem = new System.Windows.Forms.CheckBox();
            this.textBoxFormaPag = new System.Windows.Forms.TextBox();
            this.textBoxSaida = new System.Windows.Forms.TextBox();
            this.textBoxEntrada = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.panelItemLinhaCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItemLinhaCaixa
            // 
            this.panelItemLinhaCaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelItemLinhaCaixa.Controls.Add(this.checkBoxItem);
            this.panelItemLinhaCaixa.Controls.Add(this.textBoxFormaPag);
            this.panelItemLinhaCaixa.Controls.Add(this.textBoxSaida);
            this.panelItemLinhaCaixa.Controls.Add(this.textBoxEntrada);
            this.panelItemLinhaCaixa.Controls.Add(this.textBoxDescricao);
            this.panelItemLinhaCaixa.Controls.Add(this.textBoxData);
            this.panelItemLinhaCaixa.Location = new System.Drawing.Point(0, 0);
            this.panelItemLinhaCaixa.Name = "panelItemLinhaCaixa";
            this.panelItemLinhaCaixa.Size = new System.Drawing.Size(693, 27);
            this.panelItemLinhaCaixa.TabIndex = 1;
            // 
            // checkBoxItem
            // 
            this.checkBoxItem.AutoSize = true;
            this.checkBoxItem.Location = new System.Drawing.Point(1, 6);
            this.checkBoxItem.Name = "checkBoxItem";
            this.checkBoxItem.Size = new System.Drawing.Size(15, 14);
            this.checkBoxItem.TabIndex = 5;
            this.checkBoxItem.UseVisualStyleBackColor = true;
            // 
            // textBoxFormaPag
            // 
            this.textBoxFormaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFormaPag.Location = new System.Drawing.Point(555, 1);
            this.textBoxFormaPag.Name = "textBoxFormaPag";
            this.textBoxFormaPag.Size = new System.Drawing.Size(135, 23);
            this.textBoxFormaPag.TabIndex = 4;
            // 
            // textBoxSaida
            // 
            this.textBoxSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSaida.Location = new System.Drawing.Point(463, 1);
            this.textBoxSaida.Name = "textBoxSaida";
            this.textBoxSaida.Size = new System.Drawing.Size(84, 23);
            this.textBoxSaida.TabIndex = 3;
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEntrada.Location = new System.Drawing.Point(368, 1);
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.Size = new System.Drawing.Size(86, 23);
            this.textBoxEntrada.TabIndex = 2;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricao.Location = new System.Drawing.Point(143, 1);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(215, 23);
            this.textBoxDescricao.TabIndex = 1;
            // 
            // textBoxData
            // 
            this.textBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxData.Location = new System.Drawing.Point(17, 1);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(118, 23);
            this.textBoxData.TabIndex = 0;
            // 
            // itemLinhaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelItemLinhaCaixa);
            this.Name = "itemLinhaCaixa";
            this.Size = new System.Drawing.Size(691, 25);
            this.panelItemLinhaCaixa.ResumeLayout(false);
            this.panelItemLinhaCaixa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFormaPag;
        private System.Windows.Forms.TextBox textBoxSaida;
        private System.Windows.Forms.TextBox textBoxEntrada;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxData;
        public System.Windows.Forms.Panel panelItemLinhaCaixa;
        public System.Windows.Forms.CheckBox checkBoxItem;
    }
}
