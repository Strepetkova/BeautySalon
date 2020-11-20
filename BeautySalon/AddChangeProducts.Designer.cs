
namespace BeautySalon
{
    partial class AddChangeProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddChangeProdLb = new System.Windows.Forms.Label();
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.IDlb = new System.Windows.Forms.Label();
            this.namelb = new System.Windows.Forms.Label();
            this.pricelb = new System.Windows.Forms.Label();
            this.descriptionlb = new System.Windows.Forms.Label();
            this.imagelb = new System.Windows.Forms.Label();
            this.manufacterlb = new System.Windows.Forms.Label();
            this.IDtb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.descriptionRtb = new System.Windows.Forms.RichTextBox();
            this.activechb = new System.Windows.Forms.CheckBox();
            this.Imagepb = new System.Windows.Forms.PictureBox();
            this.manufacterCmb = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user38DataSet1 = new BeautySalon.user38DataSet1();
            this.manufacturerTableAdapter = new BeautySalon.user38DataSet1TableAdapters.ManufacturerTableAdapter();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.attachButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagepb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user38DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddChangeProdLb
            // 
            this.AddChangeProdLb.AutoSize = true;
            this.AddChangeProdLb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddChangeProdLb.Location = new System.Drawing.Point(370, 20);
            this.AddChangeProdLb.Name = "AddChangeProdLb";
            this.AddChangeProdLb.Size = new System.Drawing.Size(175, 19);
            this.AddChangeProdLb.TabIndex = 0;
            this.AddChangeProdLb.Text = "Добавление товара";
            // 
            // logoPb
            // 
            this.logoPb.Image = global::BeautySalon.Properties.Resources.beauty_logo;
            this.logoPb.Location = new System.Drawing.Point(301, 10);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(63, 49);
            this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPb.TabIndex = 12;
            this.logoPb.TabStop = false;
            // 
            // IDlb
            // 
            this.IDlb.AutoSize = true;
            this.IDlb.Location = new System.Drawing.Point(247, 86);
            this.IDlb.Name = "IDlb";
            this.IDlb.Size = new System.Drawing.Size(117, 18);
            this.IDlb.TabIndex = 13;
            this.IDlb.Text = "Идентификатор";
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Location = new System.Drawing.Point(193, 129);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(161, 18);
            this.namelb.TabIndex = 14;
            this.namelb.Text = "Наименование товара";
            // 
            // pricelb
            // 
            this.pricelb.AutoSize = true;
            this.pricelb.Location = new System.Drawing.Point(269, 184);
            this.pricelb.Name = "pricelb";
            this.pricelb.Size = new System.Drawing.Size(82, 18);
            this.pricelb.TabIndex = 15;
            this.pricelb.Text = "Стоимость";
            // 
            // descriptionlb
            // 
            this.descriptionlb.AutoSize = true;
            this.descriptionlb.Location = new System.Drawing.Point(269, 240);
            this.descriptionlb.Name = "descriptionlb";
            this.descriptionlb.Size = new System.Drawing.Size(74, 18);
            this.descriptionlb.TabIndex = 16;
            this.descriptionlb.Text = "Описание";
            // 
            // imagelb
            // 
            this.imagelb.AutoSize = true;
            this.imagelb.Location = new System.Drawing.Point(183, 373);
            this.imagelb.Name = "imagelb";
            this.imagelb.Size = new System.Drawing.Size(160, 18);
            this.imagelb.TabIndex = 18;
            this.imagelb.Text = "Главное изображение";
            // 
            // manufacterlb
            // 
            this.manufacterlb.AutoSize = true;
            this.manufacterlb.Location = new System.Drawing.Point(230, 519);
            this.manufacterlb.Name = "manufacterlb";
            this.manufacterlb.Size = new System.Drawing.Size(113, 18);
            this.manufacterlb.TabIndex = 19;
            this.manufacterlb.Text = "Производитель";
            // 
            // IDtb
            // 
            this.IDtb.Location = new System.Drawing.Point(374, 86);
            this.IDtb.Name = "IDtb";
            this.IDtb.ReadOnly = true;
            this.IDtb.Size = new System.Drawing.Size(171, 26);
            this.IDtb.TabIndex = 20;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(374, 126);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(413, 26);
            this.nameTb.TabIndex = 21;
            // 
            // pricetb
            // 
            this.pricetb.Location = new System.Drawing.Point(374, 181);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(171, 26);
            this.pricetb.TabIndex = 22;
            // 
            // descriptionRtb
            // 
            this.descriptionRtb.BackColor = System.Drawing.Color.White;
            this.descriptionRtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionRtb.Location = new System.Drawing.Point(374, 229);
            this.descriptionRtb.Name = "descriptionRtb";
            this.descriptionRtb.Size = new System.Drawing.Size(384, 63);
            this.descriptionRtb.TabIndex = 23;
            this.descriptionRtb.Text = "";
            // 
            // activechb
            // 
            this.activechb.AutoSize = true;
            this.activechb.Checked = true;
            this.activechb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activechb.Enabled = false;
            this.activechb.Location = new System.Drawing.Point(374, 314);
            this.activechb.Name = "activechb";
            this.activechb.Size = new System.Drawing.Size(83, 22);
            this.activechb.TabIndex = 24;
            this.activechb.Text = "Активен";
            this.activechb.UseVisualStyleBackColor = true;
            // 
            // Imagepb
            // 
            this.Imagepb.Location = new System.Drawing.Point(374, 352);
            this.Imagepb.Name = "Imagepb";
            this.Imagepb.Size = new System.Drawing.Size(146, 103);
            this.Imagepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagepb.TabIndex = 25;
            this.Imagepb.TabStop = false;
            // 
            // manufacterCmb
            // 
            this.manufacterCmb.DataSource = this.manufacturerBindingSource;
            this.manufacterCmb.DisplayMember = "Name";
            this.manufacterCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacterCmb.FormattingEnabled = true;
            this.manufacterCmb.Location = new System.Drawing.Point(374, 516);
            this.manufacterCmb.Name = "manufacterCmb";
            this.manufacterCmb.Size = new System.Drawing.Size(259, 26);
            this.manufacterCmb.TabIndex = 26;
            this.manufacterCmb.ValueMember = "ID";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.user38DataSet1;
            // 
            // user38DataSet1
            // 
            this.user38DataSet1.DataSetName = "user38DataSet1";
            this.user38DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(35, 566);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(102, 33);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(784, 566);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 33);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // attachButton
            // 
            this.attachButton.BackColor = System.Drawing.Color.White;
            this.attachButton.Location = new System.Drawing.Point(374, 470);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(109, 26);
            this.attachButton.TabIndex = 29;
            this.attachButton.Text = "Прикрепить";
            this.attachButton.UseVisualStyleBackColor = false;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddChangeProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(965, 615);
            this.Controls.Add(this.attachButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.manufacterCmb);
            this.Controls.Add(this.Imagepb);
            this.Controls.Add(this.activechb);
            this.Controls.Add(this.descriptionRtb);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.IDtb);
            this.Controls.Add(this.manufacterlb);
            this.Controls.Add(this.imagelb);
            this.Controls.Add(this.descriptionlb);
            this.Controls.Add(this.pricelb);
            this.Controls.Add(this.namelb);
            this.Controls.Add(this.IDlb);
            this.Controls.Add(this.logoPb);
            this.Controls.Add(this.AddChangeProdLb);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddChangeProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление/Редактирование товара";
            this.Load += new System.EventHandler(this.AddChangeProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagepb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user38DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddChangeProdLb;
        private System.Windows.Forms.PictureBox logoPb;
        private System.Windows.Forms.Label IDlb;
        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.Label pricelb;
        private System.Windows.Forms.Label descriptionlb;
        private System.Windows.Forms.Label imagelb;
        private System.Windows.Forms.Label manufacterlb;
        private System.Windows.Forms.TextBox IDtb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.RichTextBox descriptionRtb;
        private System.Windows.Forms.CheckBox activechb;
        private System.Windows.Forms.PictureBox Imagepb;
        private System.Windows.Forms.ComboBox manufacterCmb;
        private user38DataSet1 user38DataSet1;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private user38DataSet1TableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}