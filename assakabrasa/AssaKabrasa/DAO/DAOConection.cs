using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace AssaKabrasa.DAO
{
    class DAOConexao
    {
        private string erro;
        MySqlConnection conect = new MySqlConnection();

        public string strConexao = @"Server = localhost; Port= 3306; Database=assakabrasa; User Id = root;
                                   Password=;";

        public string stringConexao;

        //construtor
        public DAOConexao() { }
        public DAOConexao(string dadosConexao)
        {
            conect = new MySqlConnection();
            stringConexao = dadosConexao;
            conect.ConnectionString = dadosConexao;
        }

        public string strconexao
        {
            get { return strconexao; }
            set { strconexao = value; }
        }

        public MySqlConnection ObjetoConexao
        {
            get { return conect; }
            set { conect = value; }
        }

        public string conectar_bd()
        {
            desconectar_bd();
            conect.ConnectionString = strConexao;
            try
            {
                conect.Open();
                if (conect.State == System.Data.ConnectionState.Open)
                {
                   // MessageBox.Show("Conectado");
                    return "Banco de Dados Conectado!";
                }
                else
                {
                   // MessageBox.Show("Não conectado");
                    return "Erro ao Conectar!";
                }
            }
            catch (Exception e)
            {
                erro = e.Message;
            }
            return "Falha na conexao com o banco de dados: " + erro;
        }

        public string desconectar_bd()
        {
            try
            {
                conect.Close();
                if (conect.State == System.Data.ConnectionState.Closed)
                {
                   // MessageBox.Show("Conexão fechada!");
                    return "Fim da conexão!";
                }
                else
                {
                   // MessageBox.Show("Error ao fechar conexão");
                    return "Erro ao desconectar!";
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }
    }
}
