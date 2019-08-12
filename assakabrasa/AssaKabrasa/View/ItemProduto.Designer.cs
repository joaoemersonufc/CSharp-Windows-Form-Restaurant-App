namespace AssaKabrasa.View
{
    partial class ItemProduto
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
            this.labelNameProduto = new System.Windows.Forms.Label();
            this.pictureBoxProduto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameProduto
            // 
            this.labelNameProduto.AutoSize = true;
            this.labelNameProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameProduto.Location = new System.Drawing.Point(15, 77);
            this.labelNameProduto.Name = "labelNameProduto";
            this.labelNameProduto.Size = new System.Drawing.Size(98, 16);
            this.labelNameProduto.TabIndex = 5;
            this.labelNameProduto.Text = "Nome_produto";
            // 
            // pictureBoxProduto
            // 
            this.pictureBoxProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProduto.Location = new System.Drawing.Point(28, 5);
            this.pictureBoxProduto.Name = "pictureBoxProduto";
            this.pictureBoxProduto.Size = new System.Drawing.Size(75, 69);
            this.pictureBoxProduto.TabIndex = 4;
            this.pictureBoxProduto.TabStop = false;
            // 
            // ItemProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelNameProduto);
            this.Controls.Add(this.pictureBoxProduto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ItemProduto";
            this.Size = new System.Drawing.Size(128, 96);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBoxProduto;
        public System.Windows.Forms.Label labelNameProduto;
    }
}
