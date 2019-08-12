using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssaKabrasa
{
    using View;
    
    public partial class ItemCategoria : UserControl
    {
        public ItemCategoria()
        {
            InitializeComponent();
        }

        private string _name;
        private Image _icon;
        
        public string NameItem {
            get { return _name; }
            set { _name = value; labelName.Text = value; }
       }
        public Image IconItem
        {
            get { return _icon; }
            set { _icon = value; pictureBoxCategoria.Image = value; }
        }
       
    }
    //public string NameItem { get => _name; set => _name = value; }
    //public Image IconItem { get => _icon; set => _icon = value; }
}

