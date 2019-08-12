using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 @author Include Jr - Henrique Lopes Lima.
*/
namespace AssaKabrasa.Model
{
    class Comanda
    {
        private int n_comanda;
        private ArrayList produtos = new ArrayList();
        private int quantidade;
        private ArrayList subtotal = new ArrayList();
        private decimal valor_total;
        private int data;

        public Comanda(int n_comanda, ArrayList produtos, int quantidade, ArrayList subtotal, decimal valor_total, int data)
        {
            this.n_comanda = n_comanda;
            this.produtos = produtos;
            this.quantidade = quantidade;
            this.subtotal = subtotal;
            this.valor_total = valor_total;
            this.data = data;
        }

        public int N_comanda { get => n_comanda; set => n_comanda = value; }
        public ArrayList Produtos { get => produtos; set => produtos = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public ArrayList Subtotal { get => subtotal; set => subtotal = value; }
        public decimal Valor_total { get => valor_total; set => valor_total = value; }
        public int Data { get => data; set => data = value; }
    }
}
