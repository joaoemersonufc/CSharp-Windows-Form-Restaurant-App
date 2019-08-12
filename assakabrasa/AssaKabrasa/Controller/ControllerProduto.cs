using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssaKabrasa.DAO;
using AssaKabrasa.Model;

namespace AssaKabrasa.Controller
{
    using DAO;
    class ControllerProduto
    {
        static DAOConexao cx = new DAOConexao();
        DAOProduto produtoDao = new DAOProduto(cx);
        DAOImagem DAOImagem = new DAOImagem(cx);
        Produto produto = new Produto();

        public List<string> BuscarTodosNome()
        {
            List<Produto> al = produtoDao.BuscarTodos();
            List<string> nomeProduto = new List<string>();
            foreach (Produto item in al)
            {
                nomeProduto.Add(item.Nome);
            }
            return nomeProduto;
        }

        public string BuscarTodosDescricao(string nome)
        {
            string al = produtoDao.VerificarDescricao(nome);

            return al;
            
        }

        public decimal BuscarTodosPreco(string nome)
        {
            decimal al = produtoDao.VerificarPreco(nome);
           
            return al;

        }



        public List<int> BuscarTodasCategoriasID()
        {
            List<Produto> a2 = produtoDao.BuscarTodos();
            List<int> idProduto = new List<int>();
            foreach (Produto item in a2)
            {
                idProduto.Add(item.N_produto);
            }
            return idProduto;
        }

        public string BuscarTodasCategoriasNome(string nome)
        {
            string a1 = produtoDao.VerificarCategoria(nome);

            return a1;

        }
        public void CadastrarProduto(string nome,float preco, string descricao,string nomeCat)
        {
            produtoDao.Create(nome,preco,descricao,nomeCat);
        }

        public void ExcluirProduto(string nome)
        {
            produtoDao.ExcluirProduto(nome);
        }

        public void AlterarProduto(string nomeAntigo,string novaCategoria, string nomeNovo, string valorNovo, string descricaoNova)
        {
            produtoDao.Update(nomeAntigo, novaCategoria, nomeNovo, valorNovo, descricaoNova);
        }

        public void InserirImagem(string nome, byte imagem)
        {
            DAOImagem.SalvarImagem(imagem,nome);
        }

        public void BuscarImagem(string nome, byte imagem)
        {
            DAOImagem.BuscarImagem(imagem, nome);
        }

    }
}
