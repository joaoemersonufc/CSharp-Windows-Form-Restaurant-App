using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssaKabrasa.View
{
    public partial class itemCaixa : UserControl
    {
        public itemCaixa()
        {
            InitializeComponent();
        }

        private string _data;
        private string _descricao;
        private string _entrada;
        private string _saida;
        private string _formaPag;


        public string Data
        {
            get { return _data; }
            set { _data = value; textBoxData.Text = value; }
        }

        public string Drescricao
        {
            get { return _descricao; }
            set { _descricao = value; textBoxDescricao.Text = value; }
        }

        public string Entrada
        {
            get { return _entrada; }
            set { _entrada = value; textBoxEntrada.Text = value; }
        }

        public string Saida
        {
            get { return _saida; }
            set { _saida = value; textBoxSaida.Text = value; }
        }

        public string FormaPag
        {
            get { return _formaPag; }
            set { _formaPag = value; textBoxFormaPag.Text = value; }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
