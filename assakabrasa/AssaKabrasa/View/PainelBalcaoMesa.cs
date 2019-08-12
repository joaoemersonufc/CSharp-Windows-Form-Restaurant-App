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
    using Model;

    public partial class PainelBalcaoMesa : Form
    {
        public string Parametro
        {
            get { return textBoxMesa.Text; }
            set { textBoxMesa.Text = value; }
        }

        public PainelBalcaoMesa()
        {
            InitializeComponent();
        }

        
        
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 )
            {
                e.Handled = true;
            }
        }


        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (textBoxMesa.Text == "") {
                MessageBox.Show("Mesa inexistente");
            }

            else if (Convert.ToInt64(textBoxMesa.Text) <= 30 && Convert.ToInt64(textBoxMesa.Text) != 0)
            {
                this.Close();

            }
            else
            {
                MessageBox.Show("Mesa inexistente");

            }
        }

        private void Label1_Click(object sender, EventArgs e)
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
