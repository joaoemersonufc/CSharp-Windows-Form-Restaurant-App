namespace AssaKabrasa
{
    partial class ItemCategoria
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
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxCategoria = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(37, 78);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 16);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "_Nome_";
            this.labelName.UseWaitCursor = true;
            // 
            // pictureBoxCategoria
            // 
            this.pictureBoxCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCategoria.Location = new System.Drawing.Point(28, 5);
            this.pictureBoxCategoria.Name = "pictureBoxCategoria";
            this.pictureBoxCategoria.Size = new System.Drawing.Size(75, 69);
            this.pictureBoxCategoria.TabIndex = 2;
            this.pictureBoxCategoria.TabStop = false;
            // 
            // ItemCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxCategoria);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ItemCategoria";
            this.Size = new System.Drawing.Size(130, 98);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        public System.Windows.Forms.PictureBox pictureBoxCategoria;
    }
}
