using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssaKabrasa.Model;
using MySql.Data.MySqlClient;

namespace AssaKabrasa.DAO
{
    using View;

    class DAOPedido
    {
        private DAOConexao conexao;
        private Produto produto = new Produto(); 
        public DAOPedido(DAOConexao cx)
        {
            conexao = cx;
        }

        


    }
}
