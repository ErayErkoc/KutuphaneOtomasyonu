
namespace KutuphaneOtomasyonu
{
    partial class Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            this.label1 = new System.Windows.Forms.Label();
            this.Şifretxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KullanıcıGirişBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KullanıcıAdtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "KULLANICI ADI: ";
            // 
            // Şifretxt
            // 
            this.Şifretxt.Location = new System.Drawing.Point(107, 153);
            this.Şifretxt.Name = "Şifretxt";
            this.Şifretxt.Size = new System.Drawing.Size(184, 20);
            this.Şifretxt.TabIndex = 3;
            this.Şifretxt.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ŞİFRE: ";
            // 
            // KullanıcıGirişBTN
            // 
            this.KullanıcıGirişBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.KullanıcıGirişBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KullanıcıGirişBTN.Location = new System.Drawing.Point(145, 196);
            this.KullanıcıGirişBTN.Name = "KullanıcıGirişBTN";
            this.KullanıcıGirişBTN.Size = new System.Drawing.Size(102, 30);
            this.KullanıcıGirişBTN.TabIndex = 5;
            this.KullanıcıGirişBTN.Text = "GİRİŞ";
            this.KullanıcıGirişBTN.UseVisualStyleBackColor = false;
            this.KullanıcıGirişBTN.Click += new System.EventHandler(this.KullanıcıGirişBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // KullanıcıAdtxt
            // 
            this.KullanıcıAdtxt.Location = new System.Drawing.Point(107, 127);
            this.KullanıcıAdtxt.Name = "KullanıcıAdtxt";
            this.KullanıcıAdtxt.Size = new System.Drawing.Size(184, 20);
            this.KullanıcıAdtxt.TabIndex = 7;
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(217)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(337, 270);
            this.Controls.Add(this.KullanıcıAdtxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KullanıcıGirişBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Şifretxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Şifretxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button KullanıcıGirişBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox KullanıcıAdtxt;
    }
}

