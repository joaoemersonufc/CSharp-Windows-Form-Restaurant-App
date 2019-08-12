using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AssaKabrasa.Model;

namespace AssaKabrasa.DAO
{
    using View;

    class DAOAdm
    {
        private DAOConexao conexao;
        private Adm modelo = new Adm();

        public DAOAdm(DAOConexao cx)
        {
            conexao = cx;
        }

        public void Create(Adm modelo)
        {
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"insert into adm values(null, @login, @cod_pergunta, @resposta, @senha);"
                };

                cmd.Parameters.AddWithValue("login", modelo.Login.ToString());
                cmd.Parameters.AddWithValue("senha", modelo.Senha.ToString());
                cmd.Parameters.AddWithValue("cod_pergunta",modelo.Cod_pergunta.ToString());
                cmd.Parameters.AddWithValue("resposta", modelo.Resposta.ToString());

                cmd.ExecuteNonQuery();
                conexao.desconectar_bd();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Salvar " + ex.Message);
            }
        }

        public void NovaSenha(Adm modelo)
        {
            PainelRecuperacao senha = new PainelRecuperacao();

            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"UPDATE adm SET senha = @senha;"
                };

                cmd.Parameters.AddWithValue("senha", modelo.Senha.ToString());

                cmd.ExecuteNonQuery();
                conexao.desconectar_bd();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Salvar nova senha " + ex.Message);
            }
        }
        public bool ExisteAdm()
        {
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;

                cmd.CommandText = @"SELECT * FROM adm";

                //Executando query
                var result = cmd.ExecuteScalar();

                //Verificando se tem retorno do banco de dados
                if (result != null)
                {
                    return true;
                }
                conexao.desconectar_bd();
                return false;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Salvar " + ex.Message);
            }
        }

        public object ValidarLogin(string login, string senha)
        {
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;

                cmd.CommandText = @"SELECT login FROM adm";

                //Executando query
                var result = cmd.ExecuteScalar();

                
                //Verificando o retorno do banco de dados
                if (Convert.ToString(result) == login)
                {
                    cmd.CommandText = @"SELECT senha FROM adm";

                    var result2 = cmd.ExecuteScalar();

                    if (Convert.ToString(result2) == senha)
                    {
                        return true;
                    }

                    return false;
                    
                }
                conexao.desconectar_bd();
                return false;
                
            }
            catch (MySqlException ex)
            {
                throw new Exception("Ocorreu um erro ao tentar entrar no sistema. " + ex.Message);
            }
        }

        public object EsqueceuSenha(int cod_pergunta,string resposta)
        {
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;

                cmd.CommandText = @"SELECT cod_pergunta FROM adm";

                //Executando query
                var result = cmd.ExecuteScalar();


                //Verificando o retorno do banco de dados
                if (Convert.ToInt32(result) == cod_pergunta)
                {
                    cmd.CommandText = @"SELECT resposta FROM adm";

                    var result2 = cmd.ExecuteScalar();

                    if (Convert.ToString(result2) == resposta)
                    {
                        return true;
                    }

                    return false;

                }
                conexao.desconectar_bd();
                return false;

            }
            catch (MySqlException ex)
            {
                throw new Exception("Ocorreu um erro ao tentar recuperar. " + ex.Message);
            }
        }

    }

}
