namespace AssaKabrasa.View
{
    partial class PanelMesaSegunda
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
            this.SuspendLayout();
            // 
            // labelMesa
            // 
            this.labelMesa.AutoSize = true;
            this.labelMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMesa.Location = new System.Drawing.Point(39, 34);
            this.labelMesa.Name = "labelMesa";
            this.labelMesa.Size = new System.Drawing.Size(152, 37);
            this.labelMesa.TabIndex = 0;
            this.labelMesa.Text = "MESA 00";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(212, 23);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(171, 48);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "ABRIR";
            this.btnAbrir.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(212, 81);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(171, 48);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnConta
            // 
            this.btnConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConta.Location = new System.Drawing.Point(212, 140);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(171, 48);
            this.btnConta.TabIndex = 3;
            this.btnConta.Text = "CONTA";
            this.btnConta.UseVisualStyleBackColor = true;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Location = new System.Drawing.Point(212, 200);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(171, 48);
            this.btnTransferir.TabIndex = 4;
            this.btnTransferir.Text = "TRANSFERIR";
            this.btnTransferir.UseVisualStyleBackColor = true;
            // 
            // PanelBalcaoMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 291);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnConta);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.labelMesa);
            this.MaximizeBox = false;
            this.Name = "PanelBalcaoMesa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMesa;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Button btnTransferir;
    }
}