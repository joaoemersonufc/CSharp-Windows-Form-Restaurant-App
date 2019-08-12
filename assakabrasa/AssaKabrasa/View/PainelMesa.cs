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
    using Controller;
    public partial class PainelMesa : Form
    {
        PainelMesas painelMesas = new PainelMesas();
        ControllerMesa ControllerMesa = new ControllerMesa();

        public PainelMesa()
        {
            InitializeComponent();
        }

        private void TextBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            ControllerMesa.CadastrarMesa(Convert.ToInt32(textBoxNumero.Text), 0);

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExluir_Click(object sender, EventArgs e)
        {

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
