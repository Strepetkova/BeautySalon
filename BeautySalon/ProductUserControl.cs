using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl()
        {
            InitializeComponent();
        }

        [Description("Картинка для товара"), Category("Макет")] // Data")]
        public Image ProdPictImage
        {
            set => ProdPictureBox.Image = value;
        }

        [Description("Название товара"), Category("Data")]
        public string ProdNameText
        {
            //get => myInnerTextBox.Text;
            set => ProdNameRichtb.Text = value;
        }
        [Description("Цена товара"), Category("Data")]
        public decimal ProdPriceValue
        {
            //get => myInnerTextBox.Text;
            set => ProdPricelb.Text = value.ToString();
        }
    }
}
