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
    public partial class AddChangeProducts : Form
    {
        public static string way;
        public Model1 db { get; set; }
        public AddChangeProducts()
        {
            InitializeComponent();
        }

        private void AddChangeProducts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user38DataSet1.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.user38DataSet1.Manufacturer);

            IDlb.Visible = false;
            IDtb.Visible = false;


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(nameTb.Text) || String.IsNullOrEmpty(pricetb.Text) || Imagepb.Image==null || String.IsNullOrEmpty(manufacterCmb.Text))
            {
                MessageBox.Show("Уважаемый пользователь! Вы заполнели не все поля! Сохранение не произошло!",
                    "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id;
                bool b = int.TryParse(IDtb.Text, out id);
                decimal price = Math.Round(Convert.ToDecimal(pricetb.Text), 2);
                pricelb.Text = Convert.ToString(price);
                if (price < 0)
                {
                    MessageBox.Show("Уважаемый пользователь! Цена не может быть отрицательной! Сохранение не произошло!",
                        "Ошибка сохранения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Product prod = new Product();
                    prod.ID = id;
                    prod.Title = nameTb.Text;
                    prod.Cost = Convert.ToDecimal(pricetb.Text);
                    prod.Description = descriptionRtb.Text;

                    ImageConverter ic = new ImageConverter();
                    byte[] b1 = (byte[])ic.ConvertTo(Imagepb.Image, typeof(byte[]));
                    prod.MainImagePath = AddChangeProducts.way;
                    MessageBox.Show(AddChangeProducts.way);
                    if (activechb.Checked == true)
                        prod.IsActive = true;
                    else
                    {
                        prod.IsActive = false;
                    }
                    prod.ManufacturerID = Convert.ToInt32(manufacterCmb.SelectedValue);

                    db.Product.Add(prod);
                    try
                    {
                        db.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.InnerException.InnerException.Message);
                    }
                    
                }
            }
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите изображение автомобиля";
            ofd.Filter = "Файл jpg, gif, png| *.jpg;*.gif;*.png|Все файлы (*.*)|*.*";


            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Imagepb.Image = Image.FromFile(ofd.FileName);
                AddChangeProducts.way = ofd.SafeFileName;
                MessageBox.Show(ofd.SafeFileName);
                //Imagepb.Image.Save(@"C: \Users\user\Documents\Учебная практика\11 - Магазин косметики(ДЭ 2020 осень)\Ресурсы для задания\");
            }
            else{}
        }
    }
}
