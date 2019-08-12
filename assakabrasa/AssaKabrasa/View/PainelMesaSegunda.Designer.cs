namespace AssaKabrasa.View
{
    partial class PainelMesaSegunda
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
            this.labelMesa = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConta = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.pictureBoxMesa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMesa
            // 
            this.labelMesa.AutoSize = true;
            this.labelMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelMesa.Location = new System.Drawing.Point(68, 34);
            this.labelMesa.Name = "labelMesa";
            this.labelMesa.Size = new System.Drawing.Size(89, 24);
            this.labelMesa.TabIndex = 0;
            this.labelMesa.Text = "MESA 00";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(212, 23);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(145, 35);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "ABRIR";
            this.btnAbrir.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(212, 81);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(145, 35);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnConta
            // 
            this.btnConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConta.Location = new System.Drawing.Point(212, 140);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(145, 35);
            this.btnConta.TabIndex = 3;
            this.btnConta.Text = "CONTA";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.BtnConta_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Location = new System.Drawing.Point(212, 200);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(145, 35);
            this.btnTransferir.TabIndex = 4;
            this.btnTransferir.Text = "TRANSFERIR";
            this.btnTransferir.UseVisualStyleBackColor = true;
            // 
            // pictureBoxMesa
            // 
            this.pictureBoxMesa.Location = new System.Drawing.Point(48, 75);
            this.pictureBoxMesa.Name = "pictureBoxMesa";
            this.pictureBoxMesa.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxMesa.TabIndex = 5;
            this.pictureBoxMesa.TabStop = false;
            // 
            // PainelMesaSegunda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 257);
            this.Controls.Add(this.pictureBoxMesa);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnConta);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.labelMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PainelMesaSegunda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.PictureBox pictureBoxMesa;
        public System.Windows.Forms.Label labelMesa;
    }
}