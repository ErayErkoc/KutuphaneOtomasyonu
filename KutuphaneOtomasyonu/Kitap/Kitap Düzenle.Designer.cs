
namespace KutuphaneOtomasyonu.Kitap
{
    partial class Kitap_Düzenle
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
            this.KitapGüncellebtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Yayınevitxt = new System.Windows.Forms.TextBox();
            this.KitapTürütxt = new System.Windows.Forms.TextBox();
            this.Yazartxt = new System.Windows.Forms.TextBox();
            this.KitapAdtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // KitapGüncellebtn
            // 
            this.KitapGüncellebtn.Location = new System.Drawing.Point(105, 167);
            this.KitapGüncellebtn.Name = "KitapGüncellebtn";
            this.KitapGüncellebtn.Size = new System.Drawing.Size(150, 30);
            this.KitapGüncellebtn.TabIndex = 22;
            this.KitapGüncellebtn.Text = "GÜNCELLE";
            this.KitapGüncellebtn.UseVisualStyleBackColor = true;
            this.KitapGüncellebtn.Click += new System.EventHandler(this.KitapGüncellebtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(91, 118);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(181, 20);
            this.numericUpDown1.TabIndex = 21;
            // 
            // Yayınevitxt
            // 
            this.Yayınevitxt.Location = new System.Drawing.Point(91, 92);
            this.Yayınevitxt.Name = "Yayınevitxt";
            this.Yayınevitxt.Size = new System.Drawing.Size(181, 20);
            this.Yayınevitxt.TabIndex = 20;
            // 
            // KitapTürütxt
            // 
            this.KitapTürütxt.Location = new System.Drawing.Point(91, 66);
            this.KitapTürütxt.Name = "KitapTürütxt";
            this.KitapTürütxt.Size = new System.Drawing.Size(181, 20);
            this.KitapTürütxt.TabIndex = 19;
            // 
            // Yazartxt
            // 
            this.Yazartxt.Location = new System.Drawing.Point(91, 37);
            this.Yazartxt.Name = "Yazartxt";
            this.Yazartxt.Size = new System.Drawing.Size(181, 20);
            this.Yazartxt.TabIndex = 18;
            // 
            // KitapAdtxt
            // 
            this.KitapAdtxt.Location = new System.Drawing.Point(91, 12);
            this.KitapAdtxt.Name = "KitapAdtxt";
            this.KitapAdtxt.Size = new System.Drawing.Size(181, 20);
            this.KitapAdtxt.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sayfa Sayısı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Yayınevi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kitap Türü :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yazar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kitap Adı :";
            // 
            // Kitap_Düzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KitapGüncellebtn);
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
            this.Name = "Kitap_Düzenle";
            this.Text = "Kitap_Düzenle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Kitap_Düzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button KitapGüncellebtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox Yayınevitxt;
        private System.Windows.Forms.TextBox KitapTürütxt;
        private System.Windows.Forms.TextBox Yazartxt;
        private System.Windows.Forms.TextBox KitapAdtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}