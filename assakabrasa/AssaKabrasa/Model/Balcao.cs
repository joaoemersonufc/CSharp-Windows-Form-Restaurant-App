using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssaKabrasa.Model
{
    public class Balcao
    {
        private string mesa;

        public Balcao() { }

        public Balcao(string mesa)
        {
            this.mesa = mesa;
        }

        public string Mesa { get => mesa; set => mesa = value; }



    }
}
