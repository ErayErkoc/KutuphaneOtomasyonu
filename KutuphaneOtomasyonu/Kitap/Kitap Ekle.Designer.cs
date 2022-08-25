
namespace KutuphaneOtomasyonu.Kitap
{
    partial class Kitap_Ekle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KitapAdtxt = new System.Windows.Forms.TextBox();
            this.Yazartxt = new System.Windows.Forms.TextBox();
            this.KitapTürütxt = new System.Windows.Forms.TextBox();
            this.Yayınevitxt = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.KitapEklebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kitap Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yayınevi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sayfa Sayısı : ";
            // 
            // KitapAdtxt
            // 
            this.KitapAdtxt.Location = new System.Drawing.Point(97, 39);
            this.KitapAdtxt.Name = "KitapAdtxt";
            this.KitapAdtxt.Size = new System.Drawing.Size(181, 20);
            this.KitapAdtxt.TabIndex = 6;
            // 
            // Yazartxt
            // 
            this.Yazartxt.Location = new System.Drawing.Point(97, 64);
            this.Yazartxt.Name = "Yazartxt";
            this.Yazartxt.Size = new System.Drawing.Size(181, 20);
            this.Yazartxt.TabIndex = 7;
            // 
            // KitapTürütxt
            // 
            this.KitapTürütxt.Location = new System.Drawing.Point(97, 93);
            this.KitapTürütxt.Name = "KitapTürütxt";
            this.KitapTürütxt.Size = new System.Drawing.Size(181, 20);
            this.KitapTürütxt.TabIndex = 8;
            // 
            // Yayınevitxt
            // 
            this.Yayınevitxt.Location = new System.Drawing.Point(97, 119);
            this.Yayınevitxt.Name = "Yayınevitxt";
            this.Yayınevitxt.Size = new System.Drawing.Size(181, 20);
            this.Yayınevitxt.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(97, 145);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(181, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // KitapEklebtn
            // 
            this.KitapEklebtn.Location = new System.Drawing.Point(111, 194);
            this.KitapEklebtn.Name = "KitapEklebtn";
            this.KitapEklebtn.Size = new System.Drawing.Size(150, 30);
            this.KitapEklebtn.TabIndex = 11;
            this.KitapEklebtn.Text = "KAYDET";
            this.KitapEklebtn.UseVisualStyleBackColor = true;
            this.KitapEklebtn.Click += new System.EventHandler(this.KitapEklebtn_Click);
            // 
            // Kitap_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.KitapEklebtn);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Yayınevitxt);
            this.Controls.Add(this.KitapTürütxt);
            this.Controls.Add(this.Yazartxt);
            this.Controls.Add(this.KitapAdtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kitap_Ekle";
            this.Text = "Kitap_Ekle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Kitap_Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox KitapAdtxt;
        private System.Windows.Forms.TextBox Yazartxt;
        private System.Windows.Forms.TextBox KitapTürütxt;
        private System.Windows.Forms.TextBox Yayınevitxt;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button KitapEklebtn;
    }
}