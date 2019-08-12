namespace AssaKabrasa.View
{
    partial class PainelBalcaoMesa
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMesa = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pictureBoxMesa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(123, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecionar mesa:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBoxMesa
            // 
            this.textBoxMesa.Location = new System.Drawing.Point(121, 46);
            this.textBoxMesa.Name = "textBoxMesa";
            this.textBoxMesa.Size = new System.Drawing.Size(167, 20);
            this.textBoxMesa.TabIndex = 1;
            this.textBoxMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(120, 75);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(168, 40);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // pictureBoxMesa
            // 
            this.pictureBoxMesa.Location = new System.Drawing.Point(14, 15);
            this.pictureBoxMesa.Name = "pictureBoxMesa";
            this.pictureBoxMesa.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxMesa.TabIndex = 3;
            this.pictureBoxMesa.TabStop = false;
            // 
            // PainelBalcaoMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 138);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxMesa);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.textBoxMesa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PainelBalcaoMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de mesa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxMesa;
        public System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.TextBox textBoxMesa;
    }
}