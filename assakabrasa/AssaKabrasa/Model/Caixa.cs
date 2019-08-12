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
    class Caixa
    {
        private int data;
        private decimal saldo_inicial;
        private decimal saldo_final;
        private decimal saidas;
        private decimal entradas;

        public Caixa(int data, decimal saldo_inicial, decimal saldo_final, decimal saidas, decimal entradas)
        {
            this.data = data;
            this.saldo_inicial = saldo_inicial;
            this.saldo_final = saldo_final;
            this.saidas = saidas;
            this.entradas = entradas;
    
        }

        public int Data { get => data; set => data = value; }
        public decimal Saldo_inicial { get => saldo_inicial; set => saldo_inicial = value; }
        public decimal Saldo_final { get => saldo_final; set => saldo_final = value; }
        public decimal Saidas { get => saidas; set => saidas = value; }
        public decimal Entradas { get => entradas; set => entradas = value; }
    }

}
