using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssaKabrasa
{
    using AssaKabrasa.View;
    using Controller;
    using DAO;

    public partial class MDIParentPrincipal : Form
    {
        DateTime data_hora;

        public MDIParentPrincipal()
        {
            InitializeComponent();


            timer1.Enabled = false;


            ControllerAdm CAdm = new ControllerAdm();

            if (CAdm.ExisteAdm() == false)
            { 
                PainelInicio childForm = new PainelInicio();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                PainelLogin childForm = new PainelLogin();
                childForm.MdiParent = this;
                childForm.Show();
            } 
        }

       
        private void MDIParentPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void MDIParentPrincipal_MdiChildActivate(object sender, EventArgs a)
        {


            bool temFormsAbertos = false;

            // Descobre se ainda tem algum Form "filho" aberto

            foreach (Form f in this.MdiChildren)
            {
                // Ops, encontrou um formulário que parece estar aberto.

                // Por acaso ele está sendo fechado nesse momento?

                if (!f.Disposing)
                {
                    // Não... Então, tem pelo menos um form aberto...
                    temFormsAbertos = true;
                    break;
                }
            }
            // Tem algum form "filho" aberto?

            if (temFormsAbertos == true)
            {
                // Sim... Então esconde os controles
                
                fileMenu.Visible = false;
                balcaoMenu.Visible = false;
                mesasMenu.Visible = false;
                gerenciarMenu.Visible = false;

            }
            else
            {

                // Não... Então mostra os controles
                timer1.Enabled = true;
                fileMenu.Visible = true;
                balcaoMenu.Visible = true;
                mesasMenu.Visible = true;
                gerenciarMenu.Visible = true;

            }
            this.Refresh();
        }




        private void ViewMenuCaixa(object sender, EventArgs e)
        {
                PainelCaixa childForm = new PainelCaixa();
                childForm.MdiParent = this;
                childForm.Show();
        }

        private void ViewMenuBalcao(object sender, EventArgs e)
        {
            PainelBalcao childForm = new PainelBalcao();
            childForm.MdiParent = this;
            childForm.Show();
        }


        private void ViewMenuMesas(object sender, EventArgs e)
        {
            PainelMesas childForm = new PainelMesas();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lb_data.Text = data_hora.ToLongDateString();
            lb_hora.Text = data_hora.ToLongTimeString();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelCategoria painelCategoria = new PainelCategoria();
            painelCategoria.MdiParent = this;
            painelCategoria.Show();
        }

        private void MesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelMesa painelMesa = new PainelMesa();
            painelMesa.MdiParent = this;
            painelMesa.Show();
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelProdutos painelProdutos = new PainelProdutos();
            painelProdutos.MdiParent = this;
            painelProdutos.Show();
        }
    }
}
