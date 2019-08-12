using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssaKabrasa.Model;
using MySql.Data.MySqlClient;
namespace AssaKabrasa.DAO
{
    using System.Collections;
    using System.Windows.Forms;
    using View;

    class DAOCategoria
    {
        private DAOConexao conexao;

        public DAOCategoria(DAOConexao cx)
        {
            conexao = cx;
        }

        public void Create(string nome)
        {
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"insert into categoria values(null ,@name);"
                };

                cmd.Parameters.AddWithValue("name", nome.ToString());

                cmd.ExecuteNonQuery();
                conexao.desconectar_bd();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Salvar " + ex.Message);
            }
        }

        public void ExcluirCategoria(string nome)
        {
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"DELETE FROM categoria WHERE nome = @name;"
                };

                cmd.Parameters.AddWithValue("name", nome.ToString());

                cmd.ExecuteNonQuery();
                conexao.desconectar_bd();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Excluir " + ex.Message);
            }
        }

        public List<Categoria> BuscarTodas()
        {

            List<Categoria> categoriaList = new List<Categoria>();
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = @"SELECT * from categoria;"
                };

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                Categoria objCategoria = new Categoria();
                while (reader.Read())
                {
                    objCategoria = new Categoria((int)reader.GetValue(0), reader.GetValue(1).ToString());
                    if (objCategoria != null) categoriaList.Add(objCategoria);
                }
                reader.Close();
                conexao.desconectar_bd();
                return categoriaList;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Buscar todos " + ex.Message);
            }
        }

        public List<Categoria> BuscarTodasNome()
        {

            List<Categoria> categoriaList = new List<Categoria>();
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = @"SELECT * from categoria;"
                };
                //cmd.ExecuteNonQuery();
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                Categoria objCategoria = new Categoria();
                while (reader.Read())
                {
                    objCategoria = new Categoria((int)reader.GetValue(0), reader.GetValue(1).ToString());
                    if (objCategoria != null) categoriaList.Add(objCategoria);
                }
                reader.Close();
                conexao.desconectar_bd();
                return categoriaList;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Buscar todos " + ex.Message);
            }
        }

    }
}