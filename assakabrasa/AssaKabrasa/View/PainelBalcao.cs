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
    using AssaKabrasa.Model;
    using Controller;
    using DAO;
    public partial class PainelBalcao : Form
    {
        ControllerCategoria controllerCategoria = new ControllerCategoria();
        ControllerProduto controllerProduto = new ControllerProduto();

        public PainelBalcao()
        {
            InitializeComponent();
            labelBalcao.Refresh();

        }


        public void itemCategoria_Clique(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flowLayoutProduto.Controls.Clear();
                List<string> nome = controllerProduto.BuscarTodosNome();
                List<int> idCategoria = controllerProduto.BuscarTodasCategoriasID();
                //List<int> IDCategoria = controllerCategoria.BuscarTodasId();
                    /*if (id == i2)
                    {
                        foreach (string n in nome)
                        {

                            ItemProduto itemProduto = new ItemProduto();
                            itemProduto.Name = ("produto" ).ToString();
                            itemProduto.NameProduto = n.ToString();
                            flowLayoutProduto.Controls.Add(itemProduto);
                            itemProduto.MouseDown += new MouseEventHandler(itemProduto_Clique);
                            itemProduto.pictureBoxProduto.MouseDown += new MouseEventHandler(itemProduto_Clique);
                            
                        }
                    }
                */
                
                
            }
        }

        public void itemProduto_Clique(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ItemPedido itemPedido = new ItemPedido();
                itemPedido.Name = ("pedido").ToString();
                itemPedido.NamePedido = ("pedido").ToString();
                flowLayoutItemPedido.Controls.Add(itemPedido);
            }
        }


        private void PainelBalcao_Load(object sender, EventArgs e)
        {
            List<string> nome = controllerCategoria.BuscarTodas();
            List<int> idCategoria = controllerCategoria.BuscarTodasId();

                foreach (string n in nome)
                {
                    ItemCategoria itemCategoria = new ItemCategoria();
                    itemCategoria.Name = ("categoria").ToString();
                    itemCategoria.NameItem = n.ToString();
                    flowLayoutCategoria.Controls.Add(itemCategoria);
                    itemCategoria.MouseDown += new MouseEventHandler(itemCategoria_Clique);
                    itemCategoria.pictureBoxCategoria.MouseDown += new MouseEventHandler(itemCategoria_Clique);
                    
                }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            MDIParentPrincipal mDIParentPrincipal = new MDIParentPrincipal();
            PainelBalcao childForm = new PainelBalcao();
            childForm.MdiParent = mDIParentPrincipal;
            childForm.Show();
        }



        private void btnSelecionarMesa_Click(object sender, EventArgs e)
        {
            btnSelecionarMesa.Enabled = false;
            using (var PainelBalcaoMesa = new PainelBalcaoMesa())
            {
                PainelBalcaoMesa.Parametro = textBox1.Text;
                PainelBalcaoMesa.ShowDialog();
                labelBalcao.Text = "MESA " + PainelBalcaoMesa.textBoxMesa.Text;

                btnSelecionarMesa.Enabled = true;
            }
            
        }

        private void PainelBalcao_FormClosed(object sender, FormClosedEventArgs e)
        {
            PainelBalcaoMesa childForm = new PainelBalcaoMesa();
            childForm.Close();
        }
        /*
        public static List<Produto> Lista()
        {
            controllerProduto.BuscarTodosNome();
        }
        */
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
