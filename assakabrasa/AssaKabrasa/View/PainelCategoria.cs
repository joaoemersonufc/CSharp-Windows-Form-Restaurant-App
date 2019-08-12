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
    public partial class PainelCategoria : Form
    {
        bool auxiliar;
        public PainelCategoria()
        {
            InitializeComponent();

        }

        private void PainelCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            ControllerCategoria controllerCategoria = new ControllerCategoria();
            List<string> a1 = controllerCategoria.BuscarTodasNome();
            foreach (string cate in a1)
            {
                if (cate != textBoxName.Text)
                {
                    auxiliar = true;
                }
                else
                {
                    auxiliar = false;
                }
            }
            if (auxiliar == true)
            {

                if (textBoxName.Text == "")
                {
                    MessageBox.Show("Espaços vazios");
                }
                else
                {
                    controllerCategoria.CadastrarCategoria(textBoxName.Text);
                    MessageBox.Show("Cadastro feito com sucesso!");
                    textBoxName.Text = "";
                }
            }
            if (auxiliar == false)
            {

                MessageBox.Show("Esta categoria ja existe...");
                textBoxName.Text = "";

            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            PainelCategoriaAlterar painelCategoriaAlterar = new PainelCategoriaAlterar();
            painelCategoriaAlterar.Show();
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {

            ControllerCategoria controllerCategoria = new ControllerCategoria();
            List<string> a1 = controllerCategoria.BuscarTodasNome();
            foreach (string cate in a1)
            {

                if (cate == textBoxName.Text && textBoxName.Text != "")
                {
                    auxiliar = true;
                }
                else if (cate != textBoxName.Text)
                {
                    auxiliar = false;
                }


            }
            if (auxiliar == true)
            {
                controllerCategoria.ExcluirCategoria(textBoxName.Text);
                MessageBox.Show("Exclusão feita com sucesso!");
                textBoxName.Text = "";
            }
            if (auxiliar == false)
            {
                if (textBoxName.Text == "")
                {
                    MessageBox.Show("Espaços vazios");
                }
                else
                {
                    MessageBox.Show("Esta categoria nao existe...");
                    textBoxName.Text = "";
                }
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ControllerCategoria controllerCategoria = new ControllerCategoria();
            List<string> a1 = controllerCategoria.BuscarTodasNome();
            auxiliar = false;
            foreach (string cate in a1)
            {
                if (cate == textBoxName.Text)
                {
                    auxiliar = true;
                }
            }
            if (auxiliar == true)
            {
                MessageBox.Show("Esta categoria existe.");
                textBoxName.Text = "";
            }
            if (auxiliar == false)
            {
                if (textBoxName.Text == "")
                {
                    MessageBox.Show("Espaços vazios");
                }
                else
                {
                    MessageBox.Show("Esta categoria não existe...");
                    textBoxName.Text = "";
                }
            }
        }

        [STAThread]
        private void S_Click(object sender, EventArgs e)
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
                pictureBoxCategoria.ImageLocation = TrocarImagem.FileName;
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
