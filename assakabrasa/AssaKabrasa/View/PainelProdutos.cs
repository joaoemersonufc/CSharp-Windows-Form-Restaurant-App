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
using System.Globalization;
using System.IO;

namespace AssaKabrasa.View
{
    using Controller;
    using MySql.Data.MySqlClient;

    public partial class PainelProdutos : Form
    {
        ControllerProduto controllerProduto = new ControllerProduto();
        ControllerCategoria controllerCategoria = new ControllerCategoria();
        bool auxiliar;
        bool controlador2 = false;
        public PainelProdutos()
        {
            InitializeComponent();

            List<string> nome = controllerCategoria.BuscarTodas();
            

            foreach (string n in nome)
            {
                    listBox1.Items.Add(n.ToString());
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
        

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {
            
            List<string> a1 = controllerProduto.BuscarTodosNome();

            foreach (string cate in a1)
            {

                if (cate != textBoxName.Text && listBox1.SelectedItem != null && textBoxPreco.Text != "")
                {
                    
                    auxiliar = true;

                }
                else if (cate == textBoxName.Text)
                {
                    auxiliar = false;
                    controlador2 = true;
                }
                if(listBox1.SelectedItem == null) 
                {
                    auxiliar = false;
                }


            }
            if (auxiliar == true)
            {
                controllerProduto.CadastrarProduto(textBoxName.Text, float.Parse(textBoxPreco.Text, System.Globalization.CultureInfo.InvariantCulture), textBoxDescricao.Text, listBox1.SelectedItem.ToString());
                MessageBox.Show("Cadastro do produto feito com sucesso!");
                textBoxName.Text = "";
                textBoxPreco.Text = "";
                textBoxDescricao.Text = "";
            }
            else if (auxiliar == false)
            {
                if (controlador2 == true)
                {
                    MessageBox.Show("Este Produto ja existe");
                    textBoxName.Text = "";
                    textBoxPreco.Text = "";
                    textBoxDescricao.Text = "";
                }
                else if(textBoxName.Text == "" || textBoxPreco.Text == "")
                {
                    MessageBox.Show("Preencha os espaços vazios");
                }
                else if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("Clique na categoria desejada");

                }
            }
        }

        private void btnExluir_Click_1(object sender, EventArgs e)
        {

            ControllerProduto controllerProduto = new ControllerProduto();
            List<string> a1 = controllerProduto.BuscarTodosNome();
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
                controllerProduto.ExcluirProduto(textBoxName.Text);
                MessageBox.Show("Exclusão feita com sucesso!");
                textBoxName.Text = "";
                textBoxPreco.Text = "";
                textBoxDescricao.Text = "";
            }
            else if (auxiliar == false)
            {
                MessageBox.Show("Este Produto nao existe...");
                textBoxName.Text = "";
                textBoxPreco.Text = "";
                textBoxDescricao.Text = "";

            }

        }

        private void textBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';
                if (textBoxPreco.Text.Contains(","))
                    e.Handled = true;
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {

            List<string> al = controllerProduto.BuscarTodosNome();
            auxiliar = false;
            foreach (string cate in al)
            {

                if (cate == textBoxName.Text)
                {
                    auxiliar = true;

                }


            }
            if (auxiliar == true)
            {
                if (textBoxName.Text == "")
                {
                    MessageBox.Show("Insira o nome primeiro para conseguir alterar");
                }
                else if (textBoxName.Text != "")
                {
                    using (var painelProdutoAlterar = new PainelProdutoAlterar())
                    {


                        painelProdutoAlterar.ShowDialog();
                        if (painelProdutoAlterar.listBox2.SelectedItem == null)
                        {
                        }
                        if (painelProdutoAlterar.listBox2.SelectedItem != null)
                        {
                            controllerProduto.AlterarProduto(textBoxName.Text, painelProdutoAlterar.listBox2.SelectedItem.ToString(), painelProdutoAlterar.textBoxName.Text, painelProdutoAlterar.textBoxPreco.Text, painelProdutoAlterar.textBoxDescricao.Text);
                        }
                    }

                }
            }
            else if (auxiliar == false)
            {
                MessageBox.Show("Este Produto nao existe...");

            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            ControllerProduto controllerProduto = new ControllerProduto();
            List<string> a1 = controllerProduto.BuscarTodosNome();
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
                textBoxPreco.Text = controllerProduto.BuscarTodosPreco(textBoxName.Text).ToString();
                textBoxDescricao.Text = controllerProduto.BuscarTodosDescricao(textBoxName.Text).ToString();
                listBox2.Items.Clear();
                listBox2.Items.Add(controllerProduto.BuscarTodasCategoriasNome(textBoxName.Text).ToString());
                listBox2.Visible = true;
                button1.Visible = true;
            }
            else if (auxiliar == false)
            {
                MessageBox.Show("Este Produto nao existe...");
                textBoxName.Text = "";
                textBoxPreco.Text = "";
                textBoxDescricao.Text = "";

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox2.Visible = false;
            button1.Visible = false;
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
