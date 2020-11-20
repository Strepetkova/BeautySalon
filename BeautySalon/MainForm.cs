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
    public partial class MainForm : Form
    {
        Model1 db = new Model1();

        int ProdNumber = 0;
        List<Product> products = new List<Product>();
        List<ProductUserControl> controls = new List<ProductUserControl>();
        List<Manufacturer> manufacturers = new List<Manufacturer>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user38DataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.user38DataSet.Manufacturer);

            /*добавление панели User Control
             в коллецию ProductUserControl*/
            controls.Add(productUserControl1);
            controls.Add(productUserControl2);
            controls.Add(productUserControl3);
            controls.Add(productUserControl4);
            controls.Add(productUserControl5);
            controls.Add(productUserControl6);

            products = db.Product.ToList();

            UserControlLoad();//вызывание метода для отображения на форме панелей

        }

        //Метод для отображения панели на форму
        private void UserControlLoad()
        {
            int i = ProdNumber; // начальное значение товара на странице
            int maxProduct = 0;
            int viewValue = 0;
            maxProduct = products.Count;
            foreach (ProductUserControl puc in controls)
            {
                if (i < products.Count/*db.Product.Count*/())
                {
                    puc.ProdNameText = products[i].Title;
                    puc.ProdPriceValue = products[i].Cost;
                    string s = products[i].MainImagePath.Trim();
                    string file = @"C:\Users\user\Documents\Учебная практика\11 - Магазин косметики (ДЭ 2020 осень)\Ресурсы для задания\" + s;  // добавляем, чтобы бралось из папки       
                    puc.ProdPictImage = Image.FromFile(file);
                    puc.Visible = true;
                    viewValue++;
                    if (products[i].IsActive == "да")
                    {
                        puc.BackColor = Color.White;
                    }
                    else
                    {
                        puc.BackColor = Color.LightGray;
                    }
                }
                else
                {
                    puc.Visible = false;
                }
                i++; // переход к следующему товару
            }
            //int max = ProdNumber + 6;
            //if (max > 100) max = 100;

            Rangelb.Text = $"{viewValue} из {maxProduct}";
        }

        //реализация перелистывания вперед, кнопка ">"
        private void rightButton_Click(object sender, EventArgs e)
        {
            ProdNumber += 6;
            if (ProdNumber <= products.Count/*db.Product.Count()*/)
            {
                UserControlLoad();
            }
            else
            {
                ProdNumber -= 6;
            }
        }

        //реализация перелистывания назад, кнопка "<"
        private void leftButton_Click(object sender, EventArgs e)
        {
            ProdNumber -= 6;
            if (ProdNumber >= 0)
            {
                UserControlLoad();
            }
            else
            {
                ProdNumber += 6;
            }
        }

        private void Filtercb_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*фильтрация недоделана, не хватает добавленного первого элемента "Все элементы"*/
            if(Filtercb.SelectedIndex == 0)
            {
                products = db.Product.ToList();
                UserControlLoad();
            }
            else
            {
                if (Filtercb.SelectedValue == null) return;
                int n = (int)Filtercb.SelectedValue;
                var filterManufacture = db.Product.Where(x => x.ManufacturerID == n);
                products = filterManufacture.ToList();
                UserControlLoad();
            }
        }

        //public class ComboBoxWithAll : ComboBox
        //{
        //    public ComboBoxWithAll()
        //    {
        //        this.BindingContextChanged += OnBindingContextChanged;
        //    }

        //    private void OnBindingContextChanged(object sender, EventArgs args)
        //    {
        //        var item = "Все элементы";
        //        var list = this.DataSource as List<string>;
        //        if (list != null && list.Any() && list[0] != item)
        //        {
        //            list.Insert(0, item);
        //        }
        //        OnDataSourceChanged(args);
        //    }
        //}
    }
}
