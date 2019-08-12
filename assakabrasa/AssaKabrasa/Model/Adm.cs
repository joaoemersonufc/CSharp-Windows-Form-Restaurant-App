using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 @author Include Jr - João Emerson.
*/
namespace AssaKabrasa.Model
{

    public class Adm
    {

        private string login;
        private string senha;
        private int cod_pergunta;
        private string resposta;

        public Adm() {}

        public Adm(string login, string senha, int cod_pergunta, string resposta)
        { 
            this.senha = senha;
            this.login = login;
            this.cod_pergunta = cod_pergunta;
            this.resposta = resposta;
        }

        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Cod_pergunta { get => cod_pergunta; set => cod_pergunta = value; }
        public string Resposta { get => resposta; set => resposta = value; }
    }
}
