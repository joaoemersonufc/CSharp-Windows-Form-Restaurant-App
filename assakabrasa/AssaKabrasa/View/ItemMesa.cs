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
    public partial class ItemMesa : UserControl
    {
        public ItemMesa()
        {
            InitializeComponent();
        }

        private string _name;
        private Image _icon;

        public string NameItem
        {
            get { return _name; }
            set { _name = value; labelName.Text = value; }
        }
        public Image IconItem
        {
            get { return _icon; }
            set { _icon = value; pictureBoxMesa.Image = value; }
        }

        private void pictureBoxMesa_Click(object sender, EventArgs e)
        {

        }
    }
}
