﻿
namespace BeautySalon
{
    partial class ProductUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProdPictureBox = new System.Windows.Forms.PictureBox();
            this.ProdPricelb = new System.Windows.Forms.Label();
            this.ProdNameRichtb = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProdPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdPictureBox
            // 
            this.ProdPictureBox.Location = new System.Drawing.Point(36, 18);
            this.ProdPictureBox.Name = "ProdPictureBox";
            this.ProdPictureBox.Size = new System.Drawing.Size(168, 148);
            this.ProdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProdPictureBox.TabIndex = 0;
            this.ProdPictureBox.TabStop = false;
            // 
            // ProdPricelb
            // 
            this.ProdPricelb.AutoSize = true;
            this.ProdPricelb.Location = new System.Drawing.Point(96, 256);
            this.ProdPricelb.Name = "ProdPricelb";
            this.ProdPricelb.Size = new System.Drawing.Size(35, 13);
            this.ProdPricelb.TabIndex = 1;
            this.ProdPricelb.Text = "label1";
            // 
            // ProdNameRichtb
            // 
            this.ProdNameRichtb.Location = new System.Drawing.Point(37, 172);
            this.ProdNameRichtb.Name = "ProdNameRichtb";
            this.ProdNameRichtb.Size = new System.Drawing.Size(167, 70);
            this.ProdNameRichtb.TabIndex = 2;
            this.ProdNameRichtb.Text = "";
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProdNameRichtb);
            this.Controls.Add(this.ProdPricelb);
            this.Controls.Add(this.ProdPictureBox);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(241, 286);
            ((System.ComponentModel.ISupportInitialize)(this.ProdPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProdPictureBox;
        private System.Windows.Forms.Label ProdPricelb;
        private System.Windows.Forms.RichTextBox ProdNameRichtb;
    }
}
