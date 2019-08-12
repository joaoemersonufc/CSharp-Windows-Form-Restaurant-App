using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssaKabrasa.DAO;
using AssaKabrasa.Model;

namespace AssaKabrasa.Controller
{
    class ControllerCategoria
    {
        static DAOConexao cx = new DAOConexao();
        DAOCategoria categoriaDao = new DAOCategoria(cx);
        Categoria categoria = new Categoria();

        public List<string> BuscarTodas()
        {
            List<Categoria> al = categoriaDao.BuscarTodas();
            List<string> nomeCategoria = new List<string>();
            foreach (Categoria item in al)
            {
                nomeCategoria.Add(item.Nome);
            }
            return nomeCategoria;
        }

        public List<int> BuscarTodasId()
        {
            List<Categoria> a2 = categoriaDao.BuscarTodas();
            List<int> IdCategoria = new List<int>();

            foreach (Categoria item in a2)
            {
                IdCategoria.Add(item.Id_categoria);
            }
            return IdCategoria;
        }

        public List<string> BuscarTodasNome()
        {
            List<Categoria> b1 = categoriaDao.BuscarTodasNome();
            List<string> NomeCategoria = new List<string>();

            foreach (Categoria item in b1)
            {
                NomeCategoria.Add(item.Nome);
            }
            return NomeCategoria;
        }

        public void CadastrarCategoria(string nome)
        {
            categoriaDao.Create(nome);
        }

        public void ExcluirCategoria(string nome)
        {
            categoriaDao.ExcluirCategoria(nome);
        }

    }
}
