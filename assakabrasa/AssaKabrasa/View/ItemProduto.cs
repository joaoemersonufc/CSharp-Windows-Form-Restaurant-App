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
    public partial class ItemProduto : UserControl
    {
        public ItemProduto()
        {
            InitializeComponent();
        }

        private string _name;
        private Image _icon;
        

        public string NameProduto

        {
            get { return _name; }
            set { _name = value; labelNameProduto.Text = value; }
        }
        public Image IconProduto
        {
            get { return _icon; }
            set { _icon = value; pictureBoxProduto.Image = value; }
        }
        
    }
}
