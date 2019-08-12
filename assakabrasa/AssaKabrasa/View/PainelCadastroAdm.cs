using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssaKabrasa.Controller;

namespace AssaKabrasa.View
{
    public partial class PainelCadastroAdm : Form
    {
        public PainelCadastroAdm()
        {
            InitializeComponent();
        }


        private void BtnCancelar(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvar(object sender, EventArgs e)
        {
            string usuario, senha, senha2, pergunta, resposta, resposta2;
            usuario = EdtUsuario.Text;
            senha = EdtSenha.Text;
            senha2 = EdtSenha2.Text;
            pergunta = comboBox1.Text;
            resposta = EdtResposta.Text;
            resposta2 = EdtResposta2.Text;
            ControllerAdm CAdm = new ControllerAdm();
            if (CAdm.SalvarAdm(usuario, senha, senha2, pergunta, resposta, resposta2))
            {
                Hide();
                PainelLogin childForm = new PainelLogin();
                childForm.MdiParent = MDISingleton.InstanciaMDI();
                childForm.Show();
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
