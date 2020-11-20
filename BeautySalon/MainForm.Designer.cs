
namespace BeautySalon
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productUserControl1 = new BeautySalon.ProductUserControl();
            this.productUserControl2 = new BeautySalon.ProductUserControl();
            this.productUserControl3 = new BeautySalon.ProductUserControl();
            this.productUserControl4 = new BeautySalon.ProductUserControl();
            this.productUserControl5 = new BeautySalon.ProductUserControl();
            this.productUserControl6 = new BeautySalon.ProductUserControl();
            this.ListProdlb = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.Rangelb = new System.Windows.Forms.Label();
            this.Filtercb = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.user38DataSet = new BeautySalon.user38DataSet();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Seachtb = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ChangeButtton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Searchlb = new System.Windows.Forms.Label();
            this.Filterlb = new System.Windows.Forms.Label();
            this.manufacturerTableAdapter = new BeautySalon.user38DataSetTableAdapters.ManufacturerTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user38DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.productUserControl1);
            this.flowLayoutPanel1.Controls.Add(this.productUserControl2);
            this.flowLayoutPanel1.Controls.Add(this.productUserControl3);
            this.flowLayoutPanel1.Controls.Add(this.productUserControl4);
            this.flowLayoutPanel1.Controls.Add(this.productUserControl5);
            this.flowLayoutPanel1.Controls.Add(this.productUserControl6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(158, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(760, 568);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // productUserControl1
            // 
            this.productUserControl1.BackColor = System.Drawing.Color.White;
            this.productUserControl1.Location = new System.Drawing.Point(3, 3);
            this.productUserControl1.Name = "productUserControl1";
            this.productUserControl1.Size = new System.Drawing.Size(241, 279);
            this.productUserControl1.TabIndex = 0;
            // 
            // productUserControl2
            // 
            this.productUserControl2.BackColor = System.Drawing.Color.White;
            this.productUserControl2.Location = new System.Drawing.Point(250, 3);
            this.productUserControl2.Name = "productUserControl2";
            this.productUserControl2.Size = new System.Drawing.Size(241, 279);
            this.productUserControl2.TabIndex = 1;
            // 
            // productUserControl3
            // 
            this.productUserControl3.BackColor = System.Drawing.Color.White;
            this.productUserControl3.Location = new System.Drawing.Point(497, 3);
            this.productUserControl3.Name = "productUserControl3";
            this.productUserControl3.Size = new System.Drawing.Size(241, 279);
            this.productUserControl3.TabIndex = 2;
            // 
            // productUserControl4
            // 
            this.productUserControl4.BackColor = System.Drawing.Color.White;
            this.productUserControl4.Location = new System.Drawing.Point(3, 288);
            this.productUserControl4.Name = "productUserControl4";
            this.productUserControl4.Size = new System.Drawing.Size(241, 279);
            this.productUserControl4.TabIndex = 3;
            // 
            // productUserControl5
            // 
            this.productUserControl5.BackColor = System.Drawing.Color.White;
            this.productUserControl5.Location = new System.Drawing.Point(250, 288);
            this.productUserControl5.Name = "productUserControl5";
            this.productUserControl5.Size = new System.Drawing.Size(241, 279);
            this.productUserControl5.TabIndex = 4;
            // 
            // productUserControl6
            // 
            this.productUserControl6.BackColor = System.Drawing.Color.White;
            this.productUserControl6.Location = new System.Drawing.Point(497, 288);
            this.productUserControl6.Name = "productUserControl6";
            this.productUserControl6.Size = new System.Drawing.Size(241, 279);
            this.productUserControl6.TabIndex = 5;
            // 
            // ListProdlb
            // 
            this.ListProdlb.AutoSize = true;
            this.ListProdlb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListProdlb.Location = new System.Drawing.Point(462, 22);
            this.ListProdlb.Name = "ListProdlb";
            this.ListProdlb.Size = new System.Drawing.Size(142, 19);
            this.ListProdlb.TabIndex = 1;
            this.ListProdlb.Text = "Список товаров";
            // 
            // leftButton
            // 
            this.leftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.leftButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftButton.Location = new System.Drawing.Point(33, 364);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 54);
            this.leftButton.TabIndex = 2;
            this.leftButton.Text = "<";
            this.leftButton.UseVisualStyleBackColor = false;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.rightButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightButton.Location = new System.Drawing.Point(956, 358);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 54);
            this.rightButton.TabIndex = 3;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = false;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // Rangelb
            // 
            this.Rangelb.AutoSize = true;
            this.Rangelb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rangelb.Location = new System.Drawing.Point(514, 695);
            this.Rangelb.Name = "Rangelb";
            this.Rangelb.Size = new System.Drawing.Size(53, 16);
            this.Rangelb.TabIndex = 4;
            this.Rangelb.Text = "... из ...";
            // 
            // Filtercb
            // 
            this.Filtercb.DataSource = this.manufacturerBindingSource1;
            this.Filtercb.DisplayMember = "Name";
            this.Filtercb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filtercb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filtercb.FormattingEnabled = true;
            this.Filtercb.Location = new System.Drawing.Point(701, 79);
            this.Filtercb.Name = "Filtercb";
            this.Filtercb.Size = new System.Drawing.Size(302, 24);
            this.Filtercb.TabIndex = 5;
            this.Filtercb.ValueMember = "ID";
            this.Filtercb.SelectedIndexChanged += new System.EventHandler(this.Filtercb_SelectedIndexChanged);
            // 
            // manufacturerBindingSource1
            // 
            this.manufacturerBindingSource1.DataMember = "Manufacturer";
            this.manufacturerBindingSource1.DataSource = this.user38DataSet;
            // 
            // user38DataSet
            // 
            this.user38DataSet.DataSetName = "user38DataSet";
            this.user38DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataSource = typeof(BeautySalon.Manufacturer);
            // 
            // Seachtb
            // 
            this.Seachtb.Location = new System.Drawing.Point(179, 80);
            this.Seachtb.Name = "Seachtb";
            this.Seachtb.Size = new System.Drawing.Size(273, 20);
            this.Seachtb.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(843, 725);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ChangeButtton
            // 
            this.ChangeButtton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.ChangeButtton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButtton.Location = new System.Drawing.Point(518, 725);
            this.ChangeButtton.Name = "ChangeButtton";
            this.ChangeButtton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButtton.TabIndex = 8;
            this.ChangeButtton.Text = "Изменить";
            this.ChangeButtton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.DeleteButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(161, 725);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.HistoryButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryButton.Location = new System.Drawing.Point(161, 775);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(151, 23);
            this.HistoryButton.TabIndex = 10;
            this.HistoryButton.Text = "История продаж";
            this.HistoryButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BeautySalon.Properties.Resources.beauty_logo;
            this.pictureBox1.Location = new System.Drawing.Point(393, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Searchlb
            // 
            this.Searchlb.AutoSize = true;
            this.Searchlb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searchlb.Location = new System.Drawing.Point(120, 81);
            this.Searchlb.Name = "Searchlb";
            this.Searchlb.Size = new System.Drawing.Size(42, 16);
            this.Searchlb.TabIndex = 12;
            this.Searchlb.Text = "Поиск";
            // 
            // Filterlb
            // 
            this.Filterlb.AutoSize = true;
            this.Filterlb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filterlb.Location = new System.Drawing.Point(615, 82);
            this.Filterlb.Name = "Filterlb";
            this.Filterlb.Size = new System.Drawing.Size(80, 16);
            this.Filterlb.TabIndex = 13;
            this.Filterlb.Text = "Фильтрация";
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 810);
            this.Controls.Add(this.Filterlb);
            this.Controls.Add(this.Searchlb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ChangeButtton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Seachtb);
            this.Controls.Add(this.Filtercb);
            this.Controls.Add(this.Rangelb);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.ListProdlb);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список товаров";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user38DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ProductUserControl productUserControl1;
        private ProductUserControl productUserControl2;
        private ProductUserControl productUserControl3;
        private ProductUserControl productUserControl4;
        private ProductUserControl productUserControl5;
        private ProductUserControl productUserControl6;
        private System.Windows.Forms.Label ListProdlb;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Label Rangelb;
        private System.Windows.Forms.ComboBox Filtercb;
        private System.Windows.Forms.TextBox Seachtb;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ChangeButtton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Searchlb;
        private System.Windows.Forms.Label Filterlb;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private user38DataSet user38DataSet;
        private System.Windows.Forms.BindingSource manufacturerBindingSource1;
        private user38DataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
    }
}

