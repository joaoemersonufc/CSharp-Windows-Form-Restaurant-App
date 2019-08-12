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
    using Controller;

    class DAOMesa
    {
        private DAOConexao conexao;

        public DAOMesa(DAOConexao cx)
        {
            conexao = cx;
        }
        //debugar este metodo
        public void Create(int numeroMesa,int status)
        {
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"insert into mesa values(@numeroMesa, null, @status);"
                };

                cmd.Parameters.AddWithValue("numeroMesa", numeroMesa);
                cmd.Parameters.AddWithValue("status", status);

                cmd.ExecuteNonQuery();
                conexao.desconectar_bd();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Salvar " + ex.Message);
            }
        }
        public List<Mesa> BuscarTodas()
        {

            List<Mesa> mesaList = new List<Mesa>();
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = @"SELECT * from mesa;"
                };
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                Mesa objMesa = new Mesa();
                while (reader.Read())
                {
                    objMesa = new Mesa((int)reader.GetValue(0), (int)reader.GetValue(0), reader.GetValue(1).ToString());
                    if (objMesa != null) mesaList.Add(objMesa);
                }
                reader.Close();
                conexao.desconectar_bd();
                return mesaList;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Buscar todos " + ex.Message);
            }
        }

        public void ExcluirMesa(int numeroMesa)
        {
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"DELETE FROM mesa WHERE id_mesa = @numeroMesa;"
                };

                cmd.Parameters.AddWithValue("numeroMesa", numeroMesa);

                cmd.ExecuteNonQuery();
                conexao.desconectar_bd();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Excluir " + ex.Message);
            }
        }

    }
}
