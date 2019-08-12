using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 @author Include Jr - Henrique Lopes Lima.
*/
namespace AssaKabrasa.Model
{
    class Produto
    {
        private int n_produto;
        private string nome;
        private decimal valor_unitario;
        private string descricao;
        private int categoria;

        public Produto() { }

        public Produto(int n_produto, string nome, decimal valor_unitario, string descricao, int categoria)
        {
            this.n_produto = n_produto;
            this.nome = nome;
            this.valor_unitario = valor_unitario;
            this.descricao = descricao;
            this.categoria = categoria;
        }

        public int N_produto { get => n_produto; set => n_produto = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Valor_unitario { get => valor_unitario; set => valor_unitario = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Categoria { get => categoria; set => categoria = value; }
    }
}
