using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AssaKabrasa.DAO
{
    using Model;
    using Controller;
    class DAOImagem
    {
        private DAOConexao conexao;

        public DAOImagem(DAOConexao cx)
        {
            conexao = cx;
        }

        public void SalvarImagem(byte imagem,string nome)
        {
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"insert into produto imagem = @imagem WHERE nome = @nome;"
                };

                cmd.Parameters.AddWithValue("imagem", imagem);
                cmd.Parameters.AddWithValue("nome", nome.ToString());


                cmd.ExecuteNonQuery();
                conexao.desconectar_bd();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Salvar " + ex.Message);
            }
        }

        public List<Produto> BuscarImagem(byte imagem, string nome)
        {

            List<Produto> produtoList = new List<Produto>();
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"SELECT * from produto"
                };
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                Produto objProduto = new Produto();
                while (reader.Read())
                {
                    objProduto = new Produto((int)reader.GetValue(0), reader.GetValue(1).ToString(),(decimal)reader.GetValue(2),reader.GetValue(3).ToString(),(byte)reader.GetValue(4));
                    if (objProduto != null) produtoList.Add(objProduto);
                }
                reader.Close();
                conexao.desconectar_bd();
                return produtoList;

                
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Buscar todos " + ex.Message);
            }
        }
    }
}
