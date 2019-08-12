using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AssaKabrasa.View
{
    using Controller;
    public partial class PainelProdutoAlterar : Form
    {
        ControllerCategoria controllerCategoria = new ControllerCategoria();
        public PainelProdutoAlterar()
        {
            InitializeComponent();

            List<string> nome = controllerCategoria.BuscarTodas();


            foreach (string n in nome)
            {
                listBox2.Items.Add(n.ToString());
            }
        }

        [STAThread]
        private void BtnFoto_Click(object sender, EventArgs e)
        {

            Thread td = new Thread(new ThreadStart(this.EscolherImagem));
            td.SetApartmentState(ApartmentState.STA);
            td.IsBackground = true;
            td.Start();
        }

        [STAThread]
        public void EscolherImagem()
        {
            OpenFileDialog TrocarImagem = new OpenFileDialog();
            TrocarImagem.Filter = "Bitmap|*.bmp|Jpegs|*.jpg";

            if (TrocarImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProduto.ImageLocation = TrocarImagem.FileName;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Selecione a categoria");
            }else
                this.Close();
        }

        private void textBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.KeyChar = '.';
                if (textBoxPreco.Text.Contains("."))
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
