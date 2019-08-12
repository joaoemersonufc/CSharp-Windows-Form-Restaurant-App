using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssaKabrasa.View
{
    public partial class PainelMesas : Form
    {

        PainelMesaSegunda painelMesaSegunda = new PainelMesaSegunda();

        public PainelMesas()
        {
            InitializeComponent();
        }

        private void PainelMesas_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 24; i++)
            {
                ItemMesa itemMesa = new ItemMesa();
                itemMesa.NameItem = (i).ToString();
                flowLayoutPanelMesas.Controls.Add(itemMesa);
                itemMesa.pictureBoxMesa.MouseDown += new MouseEventHandler(Mesa_Clique);
            }


        }

        public void Mesa_Clique(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                PainelMesaSegunda painelMesaSegunda = new PainelMesaSegunda();
                painelMesaSegunda.MdiParent = this.MdiParent;
                painelMesaSegunda.Show();
                painelMesaSegunda.labelMesa.Text = "MESA ";

            }
        }
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

    }

}
