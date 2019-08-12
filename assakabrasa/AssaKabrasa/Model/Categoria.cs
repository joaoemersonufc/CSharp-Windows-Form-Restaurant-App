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
    class Categoria
    {
        private int id_categoria;
        private string nome;

        public Categoria() { }

        public Categoria(int id_categoria, string nome)
        {
            this.id_categoria = id_categoria;
            this.nome = nome;
        }

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
