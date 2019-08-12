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
    using View;
    using Controller;
    using DAO;

    public partial class Lancar : Form
    {
        PainelCaixa painelCaixa = new PainelCaixa();

        public string Parametro
        {
            get { return textBoxObs.Text; }
            set { textBoxObs.Text = value; }
        }

        public Lancar()
        {
            InitializeComponent();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if(comboBoxTipo.SelectedItem == null)
                MessageBox.Show("Selecione o tipo da alteração");
            else if(textBoxValor.Text != "")
                this.Close();

        }

        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';
                if (textBoxValor.Text.Contains(","))
                    e.Handled = true; 
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
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
