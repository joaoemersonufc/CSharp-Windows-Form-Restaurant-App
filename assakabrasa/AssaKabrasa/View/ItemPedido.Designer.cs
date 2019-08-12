namespace AssaKabrasa.View
{
    partial class ItemPedido
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
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxPedido = new System.Windows.Forms.PictureBox();
            this.labelQtd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(200, 57);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(24, 23);
            this.btnMenos.TabIndex = 11;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(230, 57);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(24, 23);
            this.btnMais.TabIndex = 10;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(87, 61);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 16);
            this.label.TabIndex = 9;
            this.label.Text = "QTD";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreco.Location = new System.Drawing.Point(87, 37);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(59, 16);
            this.labelPreco.TabIndex = 8;
            this.labelPreco.Text = "R$ 00,00";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(87, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 18);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Produto";
            // 
            // pictureBoxPedido
            // 
            this.pictureBoxPedido.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxPedido.Name = "pictureBoxPedido";
            this.pictureBoxPedido.Size = new System.Drawing.Size(75, 69);
            this.pictureBoxPedido.TabIndex = 6;
            this.pictureBoxPedido.TabStop = false;
            // 
            // labelQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.Location = new System.Drawing.Point(133, 63);
            this.labelQtd.Name = "labelQtd";
            this.labelQtd.Size = new System.Drawing.Size(13, 13);
            this.labelQtd.TabIndex = 12;
            this.labelQtd.Text = "1";
            // 
            // ItemPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelQtd);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxPedido);
            this.Name = "ItemPedido";
            this.Size = new System.Drawing.Size(263, 88);
            this.Load += new System.EventHandler(this.ItemPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxPedido;
        private System.Windows.Forms.Label labelQtd;
    }
}
