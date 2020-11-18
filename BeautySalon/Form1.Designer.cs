
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.Rangelb = new System.Windows.Forms.Label();
            this.productUserControl1 = new BeautySalon.ProductUserControl();
            this.productUserControl2 = new BeautySalon.ProductUserControl();
            this.productUserControl3 = new BeautySalon.ProductUserControl();
            this.productUserControl4 = new BeautySalon.ProductUserControl();
            this.productUserControl5 = new BeautySalon.ProductUserControl();
            this.productUserControl6 = new BeautySalon.ProductUserControl();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(148, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(760, 568);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(451, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список товаров";
            // 
            // leftButton
            // 
            this.leftButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftButton.Location = new System.Drawing.Point(23, 323);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 54);
            this.leftButton.TabIndex = 2;
            this.leftButton.Text = "<";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightButton.Location = new System.Drawing.Point(956, 323);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 54);
            this.rightButton.TabIndex = 3;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // Rangelb
            // 
            this.Rangelb.AutoSize = true;
            this.Rangelb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rangelb.Location = new System.Drawing.Point(479, 650);
            this.Rangelb.Name = "Rangelb";
            this.Rangelb.Size = new System.Drawing.Size(64, 16);
            this.Rangelb.TabIndex = 4;
            this.Rangelb.Text = "с ... по ...";
            // 
            // productUserControl1
            // 
            this.productUserControl1.Location = new System.Drawing.Point(3, 3);
            this.productUserControl1.Name = "productUserControl1";
            this.productUserControl1.Size = new System.Drawing.Size(241, 279);
            this.productUserControl1.TabIndex = 0;
            // 
            // productUserControl2
            // 
            this.productUserControl2.Location = new System.Drawing.Point(250, 3);
            this.productUserControl2.Name = "productUserControl2";
            this.productUserControl2.Size = new System.Drawing.Size(241, 279);
            this.productUserControl2.TabIndex = 1;
            // 
            // productUserControl3
            // 
            this.productUserControl3.Location = new System.Drawing.Point(497, 3);
            this.productUserControl3.Name = "productUserControl3";
            this.productUserControl3.Size = new System.Drawing.Size(241, 279);
            this.productUserControl3.TabIndex = 2;
            // 
            // productUserControl4
            // 
            this.productUserControl4.Location = new System.Drawing.Point(3, 288);
            this.productUserControl4.Name = "productUserControl4";
            this.productUserControl4.Size = new System.Drawing.Size(241, 279);
            this.productUserControl4.TabIndex = 3;
            // 
            // productUserControl5
            // 
            this.productUserControl5.Location = new System.Drawing.Point(250, 288);
            this.productUserControl5.Name = "productUserControl5";
            this.productUserControl5.Size = new System.Drawing.Size(241, 279);
            this.productUserControl5.TabIndex = 4;
            // 
            // productUserControl6
            // 
            this.productUserControl6.Location = new System.Drawing.Point(497, 288);
            this.productUserControl6.Name = "productUserControl6";
            this.productUserControl6.Size = new System.Drawing.Size(241, 279);
            this.productUserControl6.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 713);
            this.Controls.Add(this.Rangelb);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Список товаров";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Label Rangelb;
    }
}

