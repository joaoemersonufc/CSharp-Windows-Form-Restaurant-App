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
    using Controller;
    using DAO;
    using View;

    public partial class PainelLogin : Form
    {
       
        public PainelLogin()
        {

            InitializeComponent();

        }

        private void CancelarBttn(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EntrarBttn(object sender, EventArgs e)
        {
            string login;
            string senha;

            login = LoginUsuario.Text;
            senha = SenhaUsuario.Text;
            
            ControllerAdm adm = new ControllerAdm();
            if (Convert.ToBoolean(adm.LogarAdm(login.Trim(), senha.Trim())) == true)
            {
                Close();
                MessageBox.Show("Bem vindo!");

            }
            else
            {
                MessageBox.Show("Login ou senha inválido(a).");
            }
            

        }

        private void SenhaUsuario_TextChanged(object sender, EventArgs e)
        {
            SenhaUsuario.Font = new Font(SenhaUsuario.Font, FontStyle.Bold);
        }

        private void esqueceuSenha(object sender, EventArgs e)
        {
            PainelRecuperacao childForm = new PainelRecuperacao();
            childForm.MdiParent = MDISingleton.InstanciaMDI();
            childForm.Show();
            Close();
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
