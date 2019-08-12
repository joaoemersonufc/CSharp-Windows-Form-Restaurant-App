using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssaKabrasa.DAO;
using System.Windows.Forms;
using AssaKabrasa.Model;


namespace AssaKabrasa.Controller
{
    class ControllerAdm
    {
        static DAOConexao cx = new DAOConexao();
        DAOAdm admDao = new DAOAdm(cx);
        Adm adm = new Adm();

        // Esse metodo serve para salvar um administrador
        public bool SalvarAdm(string usuario, string senha, string senha2, string pergunta, string resposta, string resposta2) {
            if (usuario.Equals("") || (senha.Equals("")) || (senha2.Equals("")) || (pergunta.Equals("")) || (resposta.Equals("")) || (resposta2.Equals("")))
            {
                MessageBox.Show("Existem campos invalidos!");
                return false;
            }
            else if ((senha.Equals(senha2)) && (resposta.Equals(resposta2)))
            {
                int cod_pergunta = EscolherCod(pergunta);
                adm.Login = usuario;
                adm.Senha = senha;
                adm.Cod_pergunta = cod_pergunta;
                adm.Resposta = resposta;
                admDao.Create(adm);
                return true;
            }
            else
            {
                if (senha.Equals(senha2))
                {
                    MessageBox.Show("Os campos das respostas não correspondem!");
                }
                else
                {
                    MessageBox.Show("Os campos das senhas não correspondem!");
                }
                return false;
            }

        }

        // Esse metodo é o pertencente ao Esqueceu a senha?
        public bool RecuperarSenha(string pergunta, string resposta, string senha, string senha2)
        {
            int cod_pergunta = EscolherCod(pergunta);

            if ((senha.Equals("")) || (senha2.Equals("")))
            {
                MessageBox.Show("Existem campos invalidos!");
            }
            else if ((senha.Equals(senha2)) && Convert.ToBoolean(admDao.EsqueceuSenha(cod_pergunta,resposta))==true)
            {
                adm.Senha = senha;
                admDao.NovaSenha(adm);

                using (var childForm = new PainelLogin())
                {
                    childForm.MdiParent = MDISingleton.InstanciaMDI();
                    childForm.Show();
                    return true;
                    
                }
            }
            else
            {
                if (senha.Equals(senha2))
                {
                    MessageBox.Show("Os campos das respostas não correspondem!");
                }
                else
                {
                    MessageBox.Show("Os campos das senhas não correspondem!");
                }
            }
            return false;
        }

        // Metodo que auxilia na transformação de do campos pergunta em um codigo para pergunta 
        private int EscolherCod(string pergunta)
        {
            if (pergunta.Equals("Qual a cidade que você nasceu?"))
            {
                return 1;
            }
            else if (pergunta.Equals("Como é o nome do seu primeiro animal?"))
            {
                return 2;
            }
            else if (pergunta.Equals("Me diga uma data importante"))
            {
                return 3;
            }
            return 0;
        }

        // Metodo que pergunta se existe Administrador
        public bool ExisteAdm()
        {
             return admDao.ExisteAdm();
        }

        // Metodo que irá logar
        public object LogarAdm(string login,string senha)
        {
            return admDao.ValidarLogin(login,senha);
        }
    }
}
