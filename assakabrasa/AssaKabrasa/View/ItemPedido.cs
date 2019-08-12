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
    public partial class ItemPedido: UserControl
    {
        //Exemplo de preço
        double valorInicial = 15.00;
        double valorTotal = 1.00;

        public ItemPedido()
        {
            InitializeComponent();
            labelPreco.Text = Convert.ToString("R$" + valorInicial);

        }

        private string _name;
        private string _preco;
        private string _qtd;
        private Image _icon;

        private void ItemPedido_Load(object sender, EventArgs e)
        {

        }

        //public string NameItem { get => _name; set => _name = value; }
        //public Image IconItem { get => _icon; set => _icon = value; }


        public string NamePedido
        {
            get { return _name; }
            set { _name = value; labelName.Text = value; }
        }
        public string PrecoPedido
        {
            get { return _preco; }
            set { _preco = value; labelPreco.Text = value; }
        }
        public string QtdPedido
        {
            get { return _qtd; }
            set { _qtd = value; label.Text = value; }
        }
        public Image IconItem
        {
            get { return _icon; }
            set { _icon = value; pictureBoxPedido.Image = value; }
        }

        int i=1;

        private void btnMais_Click(object sender, EventArgs e)
        {       
            i++;
            labelQtd.Text = Convert.ToString(i);
            valorTotal = valorInicial * i;
            labelPreco.Text = Convert.ToString("R$" + valorTotal);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                Hide();
            }
            else if (i > 1)
            {
                i--;
                labelQtd.Text = Convert.ToString(i);
                valorTotal = valorInicial * i;
                labelPreco.Text = Convert.ToString("R$" + valorTotal);
            }
        }
    }
}
