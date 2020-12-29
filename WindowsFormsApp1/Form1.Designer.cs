namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ogrenciButton = new System.Windows.Forms.Button();
            this.oUyesiButton = new System.Windows.Forms.Button();
            this.cikisButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogrenciButton
            // 
            this.ogrenciButton.BackColor = System.Drawing.Color.CadetBlue;
            this.ogrenciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciButton.Location = new System.Drawing.Point(22, 4);
            this.ogrenciButton.Name = "ogrenciButton";
            this.ogrenciButton.Size = new System.Drawing.Size(164, 99);
            this.ogrenciButton.TabIndex = 1;
            this.ogrenciButton.Text = "Öğrenci İşlemleri";
            this.ogrenciButton.UseVisualStyleBackColor = false;
            this.ogrenciButton.Click += new System.EventHandler(this.button_Click);
            // 
            // oUyesiButton
            // 
            this.oUyesiButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.oUyesiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oUyesiButton.Location = new System.Drawing.Point(192, 4);
            this.oUyesiButton.Name = "oUyesiButton";
            this.oUyesiButton.Size = new System.Drawing.Size(141, 99);
            this.oUyesiButton.TabIndex = 3;
            this.oUyesiButton.Text = "Öğretim Üyesi İşlemleri";
            this.oUyesiButton.UseVisualStyleBackColor = false;
            this.oUyesiButton.Click += new System.EventHandler(this.oUyesiButton_Click);
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.IndianRed;
            this.cikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.Location = new System.Drawing.Point(22, 111);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(311, 90);
            this.cikisButton.TabIndex = 4;
            this.cikisButton.Text = "Çıkış";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.ogrenciButton);
            this.panel1.Controls.Add(this.cikisButton);
            this.panel1.Controls.Add(this.oUyesiButton);
            this.panel1.Location = new System.Drawing.Point(1070, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 215);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1439, 585);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ogrenciButton;
        private System.Windows.Forms.Button oUyesiButton;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Panel panel1;
    }
}

