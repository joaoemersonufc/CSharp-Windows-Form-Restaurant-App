namespace AssaKabrasa
{
    partial class MDIParentPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.balcaoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mesasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AllowMerge = false;
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.balcaoMenu,
            this.mesasMenu,
            this.gerenciarMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(884, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(57, 24);
            this.fileMenu.Text = "&Caixa";
            this.fileMenu.Click += new System.EventHandler(this.ViewMenuCaixa);
            // 
            // balcaoMenu
            // 
            this.balcaoMenu.Name = "balcaoMenu";
            this.balcaoMenu.Size = new System.Drawing.Size(66, 24);
            this.balcaoMenu.Text = "&Balcão";
            this.balcaoMenu.Click += new System.EventHandler(this.ViewMenuBalcao);
            // 
            // mesasMenu
            // 
            this.mesasMenu.Name = "mesasMenu";
            this.mesasMenu.Size = new System.Drawing.Size(62, 24);
            this.mesasMenu.Text = "&Mesas";
            this.mesasMenu.Click += new System.EventHandler(this.ViewMenuMesas);
            // 
            // gerenciarMenu
            // 
            this.gerenciarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.mesaToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.gerenciarMenu.Name = "gerenciarMenu";
            this.gerenciarMenu.Size = new System.Drawing.Size(84, 24);
            this.gerenciarMenu.Text = "Gerenciar";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // mesaToolStripMenuItem
            // 
            this.mesaToolStripMenuItem.Name = "mesaToolStripMenuItem";
            this.mesaToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.mesaToolStripMenuItem.Text = "Mesa";
            this.mesaToolStripMenuItem.Click += new System.EventHandler(this.MesaToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.ProdutoToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_data
            // 
            this.lb_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_data.AutoSize = true;
            this.lb_data.BackColor = System.Drawing.Color.White;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_data.Location = new System.Drawing.Point(430, 8);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(0, 20);
            this.lb_data.TabIndex = 11;
            // 
            // lb_hora
            // 
            this.lb_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_hora.AutoSize = true;
            this.lb_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_hora.Location = new System.Drawing.Point(781, 8);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(0, 20);
            this.lb_hora.TabIndex = 12;
            // 
            // MDIParentPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lb_hora);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParentPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParentPrincipal_Load);
            this.MdiChildActivate += new System.EventHandler(this.MDIParentPrincipal_MdiChildActivate);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.ToolStripMenuItem fileMenu;
        public System.Windows.Forms.ToolStripMenuItem balcaoMenu;
        public System.Windows.Forms.ToolStripMenuItem mesasMenu;
        public System.Windows.Forms.ToolStripMenuItem gerenciarMenu;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_hora;
        public System.Windows.Forms.Timer timer1;
    }
}



