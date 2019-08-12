namespace AssaKabrasa.View
{
    partial class ItemMesa
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
            this.pictureBoxMesa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(51, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(22, 16);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "01";
            this.labelName.UseWaitCursor = true;
            // 
            // pictureBoxMesa
            // 
            this.pictureBoxMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMesa.Location = new System.Drawing.Point(23, 3);
            this.pictureBoxMesa.Name = "pictureBoxMesa";
            this.pictureBoxMesa.Size = new System.Drawing.Size(83, 72);
            this.pictureBoxMesa.TabIndex = 4;
            this.pictureBoxMesa.TabStop = false;
            this.pictureBoxMesa.Click += new System.EventHandler(this.pictureBoxMesa_Click);
            // 
            // ItemMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxMesa);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ItemMesa";
            this.Size = new System.Drawing.Size(130, 98);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        public System.Windows.Forms.PictureBox pictureBoxMesa;
    }
}
