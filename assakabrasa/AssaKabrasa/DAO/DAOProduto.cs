using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AssaKabrasa.DAO
{
    using View;
    using Model;
    using Controller;

    class DAOProduto
    {
        bool auxiliar;
        int id_categoria;
        string nomeCategoria;
        string descricaoProduto;
        decimal precoProduto;
        int idCategoria;

        ControllerCategoria controllerCategoria = new ControllerCategoria();
        private DAOConexao conexao;

        public DAOProduto(DAOConexao cx)
        {
            conexao = cx;
        }

        MySqlConnection conect = new MySqlConnection();
        DAOConexao dAOConexao = new DAOConexao();

        public string strConexao = @"Server = localhost; Port= 3306; Database=assakabrasa; User Id = root;
                                   Password=;";

        public string stringConexao;

        //construtor
        public DAOProduto() { }
        public DAOProduto(string dadosConexao)
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

        public void Create(string nome,float preco, string descricao, string nomeCat)
        {
            List<string> Nome = controllerCategoria.BuscarTodasNome();
            foreach (string nomes in Nome)
            {
                if (nomes == nomeCat)
                {
                    auxiliar = true;
                    
                }
            }

            if (auxiliar)
            {
                try
                {
                    
                    id_categoria = VerificarID(nomeCat);
                    conexao.conectar_bd();
                    MySqlCommand cmd = new MySqlCommand
                    {
                        Connection = conexao.ObjetoConexao,

                        CommandText = @"insert into produto values(null, @id_categoria ,@name, @preco, @descricao);"
                    };

                    cmd.Parameters.AddWithValue("id_categoria", id_categoria.ToString());
                    cmd.Parameters.AddWithValue("name", nome.ToString());
                    cmd.Parameters.AddWithValue("preco", preco);
                    cmd.Parameters.AddWithValue("descricao", descricao.ToString());

                    cmd.ExecuteNonQuery();
                    conexao.desconectar_bd();
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Falha na operação Salvar " + ex.Message);
                }
            }
        }
        public string VerificarCategoria(string nome)
        {
            idCategoria = VerificarCategoriaProduto(nome);
            conexao.conectar_bd();
            try
            {

                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"SELECT * FROM categoria WHERE id_categoria=@idCategoria;"
                };
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("idCategoria", idCategoria);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    nomeCategoria = (string)reader.GetValue(1).ToString();

                }
                reader.Close();
                conexao.desconectar_bd();

                return nomeCategoria;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Buscar " + ex.Message);
            }
        }

        public int VerificarCategoriaProduto(string nome)
        {
            conexao.conectar_bd();
            try
            {

                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"SELECT * FROM produto WHERE nome=@nome;"
                };
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("nome", nome);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idCategoria = (int)reader.GetValue(1);

                }
                reader.Close();
                conexao.desconectar_bd();

                return idCategoria;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Buscar " + ex.Message);
            }
        }


        public int VerificarID(string nome)
        {
            
            conexao.conectar_bd();
            try
            {
                
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"SELECT * FROM categoria WHERE nome=@nome;"
                };
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("nome", nome);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    id_categoria = (int)reader.GetValue(0);
                    
                }
                reader.Close();
                conexao.desconectar_bd();

                return id_categoria;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Buscar " + ex.Message);
            }
        }

        public string VerificarDescricao(string nome)
        {

            conexao.conectar_bd();
            try
            {

                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"SELECT * FROM produto WHERE nome=@nome;"
                };
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("nome", nome);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    descricaoProduto = (string)reader.GetValue(4).ToString();

                }
                reader.Close();
                conexao.desconectar_bd();

                return descricaoProduto;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Buscar " + ex.Message);
            }
        }

        public decimal VerificarPreco(string nome)
        {

            conexao.conectar_bd();
            try
            {

                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"SELECT * FROM produto WHERE nome=@nome;"
                };
                MySqlDataReader reader;
                cmd.Parameters.AddWithValue("nome", nome);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    precoProduto = (decimal)reader.GetValue(3);

                }
                reader.Close();
                conexao.desconectar_bd();

                return precoProduto;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha na operação Buscar " + ex.Message);
            }
        }

        public List<Produto> BuscarTodos()
        {
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = @"SELECT * from produto;"
                };

                MySqlDataReader reader;
                List<Produto> produtoList = new List<Produto>();
                reader = cmd.ExecuteReader();
                Produto objProduto = new Produto();
                while (reader.Read())
                {
                    objProduto = new Produto( (int)reader.GetValue(0),reader.GetValue(2).ToString(),(decimal)reader.GetValue(3), reader.GetValue(4).ToString(), (int)reader.GetValue(1));
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


        public void Update(string nomeAntigo, string novaCategoria, string nomeNovo, string precoNovo, string descricaoNova)
        {
            if (novaCategoria == "" && precoNovo.ToString() == "" && descricaoNova == "")
            {
                List<string> Nome = controllerCategoria.BuscarTodasNome();
                foreach (string nomes in Nome)
                {
                    if (nomes == novaCategoria)
                    {
                        auxiliar = true;

                    }
                }
                if (!auxiliar)
                {

                    conexao.conectar_bd();
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand
                        {
                            Connection = conexao.ObjetoConexao,
                            CommandText = @"UPDATE produto SET nome = @nomeNovo WHERE nome = @nomeAntigo;"
                        };

                        cmd.Parameters.AddWithValue("nomeNovo", nomeNovo.ToString());


                        cmd.ExecuteNonQuery();
                        conexao.desconectar_bd();
                    }
                    catch (MySqlException ex)
                    {
                        throw new Exception("Falha na operação Alterar " + ex.Message);
                    }
                }
            }

            if (novaCategoria != "")
            {
                List<string> NomeCat = controllerCategoria.BuscarTodasNome();
                foreach (string nomes in NomeCat)
                {
                    if (nomes == novaCategoria)
                    {
                        auxiliar = true;

                    }
                }
                if (auxiliar)
                {

                    id_categoria = VerificarID(novaCategoria);
                    conexao.conectar_bd();
                    if (precoNovo.ToString() != "")
                    {
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand
                            {
                                Connection = conexao.ObjetoConexao,
                                CommandText = @"UPDATE produto SET id_categoria = @id_Categoria, nome = @nomeNovo , preco = @precoNovo, descricao = @descricaoNova WHERE nome = @nomeAntigo;"
                            };

                            cmd.Parameters.AddWithValue("id_Categoria", id_categoria.ToString());
                            cmd.Parameters.AddWithValue("nomeNovo", nomeNovo.ToString());
                            cmd.Parameters.AddWithValue("precoNovo", precoNovo.ToString());
                            cmd.Parameters.AddWithValue("descricaoNova", descricaoNova.ToString());
                            cmd.Parameters.AddWithValue("nomeAntigo", nomeAntigo.ToString());


                            cmd.ExecuteNonQuery();
                            conexao.desconectar_bd();
                        }
                        catch (MySqlException ex)
                        {
                            throw new Exception("Falha na operação Alterar " + ex.Message);
                        }
                    }
                    else if (precoNovo.ToString() == "")
                    {
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand
                            {
                                Connection = conexao.ObjetoConexao,
                                CommandText = @"UPDATE produto SET id_categoria = @id_Categoria, nome = @nomeNovo , descricao = @descricaoNova WHERE nome = @nomeAntigo;"
                            };

                            cmd.Parameters.AddWithValue("id_Categoria", id_categoria.ToString());
                            cmd.Parameters.AddWithValue("nomeNovo", nomeNovo.ToString());
                            cmd.Parameters.AddWithValue("descricaoNova", descricaoNova.ToString());
                            cmd.Parameters.AddWithValue("nomeAntigo", nomeAntigo.ToString());

                            cmd.ExecuteNonQuery();
                            conexao.desconectar_bd();
                        }
                        catch (MySqlException ex)
                        {
                            throw new Exception("Falha na operação Alterar " + ex.Message);
                        }
                    }
                }

            }
            else if (novaCategoria == "")
            {
                conexao.conectar_bd();
                if (precoNovo.ToString() != "")
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand
                        {
                            Connection = conexao.ObjetoConexao,
                            CommandText = @"UPDATE produto  SET nome = @nomeNovo , preco = @precoNovo, descricao = @descricaoNova WHERE nome = @nomeAntigo;"
                        };

                        cmd.Parameters.AddWithValue("nomeNovo", nomeNovo.ToString());
                        cmd.Parameters.AddWithValue("precoNovo", precoNovo.ToString());
                        cmd.Parameters.AddWithValue("descricaoNova", descricaoNova.ToString());
                        cmd.Parameters.AddWithValue("nomeAntigo", nomeAntigo.ToString());

                        cmd.ExecuteNonQuery();
                        conexao.desconectar_bd();
                    }
                    catch (MySqlException ex)
                    {
                        throw new Exception("Falha na operação Alterar " + ex.Message);
                    }
                }
                else if (precoNovo.ToString() == "")
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand
                        {
                            Connection = conexao.ObjetoConexao,
                            CommandText = @"UPDATE produto  SET nome = @nomeNovo , descricao = @descricaoNova WHERE nome = @nomeAntigo;"
                        };

                        cmd.Parameters.AddWithValue("nomeNovo", nomeNovo.ToString());
                        cmd.Parameters.AddWithValue("descricaoNova", descricaoNova.ToString());
                        cmd.Parameters.AddWithValue("nomeAntigo", nomeAntigo.ToString());

                        cmd.ExecuteNonQuery();
                        conexao.desconectar_bd();
                    }
                    catch (MySqlException ex)
                    {
                        throw new Exception("Falha na operação Alterar " + ex.Message);
                    }
                }
            }
        }
        

        public void ExcluirProduto(string nome)
        {
            conexao.conectar_bd();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conexao.ObjetoConexao,

                    CommandText = @"DELETE FROM produto WHERE nome = @name;"
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
    }

}


    

