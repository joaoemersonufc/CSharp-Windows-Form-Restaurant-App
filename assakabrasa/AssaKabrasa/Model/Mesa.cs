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
    class Mesa
    {
        private int n_mesa;
        private int n_comanda;
        private string status;

        public Mesa() { }
        public Mesa(int n_mesa, int n_comanda, string status)
        {
            this.n_mesa = n_mesa;
            this.n_comanda = n_comanda;
            this.status = status;
        }

        public int N_mesa { get => n_mesa; set => n_mesa = value; }
        public int N_comanda { get => n_comanda; set => n_comanda = value; }
        public string Status { get => status; set => status = value; }
    }
}
