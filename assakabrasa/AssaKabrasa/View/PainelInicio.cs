using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssaKabrasa.DAO;
using AssaKabrasa.View;

namespace AssaKabrasa
{
    public partial class PainelInicio : Form
    {
        public PainelInicio()
        {
            InitializeComponent();
   
            
        }
        private void BtnInicio(object sender, EventArgs e)
        {
            Hide();
            PainelCadastroAdm childForm = new PainelCadastroAdm();        
            childForm.MdiParent = MDISingleton.InstanciaMDI();
            childForm.Show();
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
