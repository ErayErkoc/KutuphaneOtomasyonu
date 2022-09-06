
namespace KutuphaneOtomasyonu.Kitap_İşlem
{
    partial class Ödünç_Ver
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
            this.KodBultxt = new System.Windows.Forms.TextBox();
            this.Arabtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.KitapAratxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VerenArabtn = new System.Windows.Forms.Button();
            this.VerenKodBultxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ÖdünçVerbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Okuyucu Adı :";
            // 
            // KodBultxt
            // 
            this.KodBultxt.Location = new System.Drawing.Point(93, 15);
            this.KodBultxt.Name = "KodBultxt";
            this.KodBultxt.Size = new System.Drawing.Size(147, 20);
            this.KodBultxt.TabIndex = 2;
            // 
            // Arabtn
            // 
            this.Arabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.Arabtn.Location = new System.Drawing.Point(257, 15);
            this.Arabtn.Name = "Arabtn";
            this.Arabtn.Size = new System.Drawing.Size(78, 20);
            this.Arabtn.TabIndex = 3;
            this.Arabtn.Text = "Ara";
            this.Arabtn.UseVisualStyleBackColor = false;
            this.Arabtn.Click += new System.EventHandler(this.Arabtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(367, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(420, 177);
            this.dataGridView2.TabIndex = 5;
            // 
            // KitapAratxt
            // 
            this.KitapAratxt.BackColor = System.Drawing.SystemColors.Window;
            this.KitapAratxt.Location = new System.Drawing.Point(367, 15);
            this.KitapAratxt.Name = "KitapAratxt";
            this.KitapAratxt.Size = new System.Drawing.Size(265, 20);
            this.KitapAratxt.TabIndex = 6;
            this.KitapAratxt.TextChanged += new System.EventHandler(this.KitapAratxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // VerenArabtn
            // 
            this.VerenArabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.VerenArabtn.Location = new System.Drawing.Point(257, 75);
            this.VerenArabtn.Name = "VerenArabtn";
            this.VerenArabtn.Size = new System.Drawing.Size(78, 20);
            this.VerenArabtn.TabIndex = 9;
            this.VerenArabtn.Text = "Ara";
            this.VerenArabtn.UseVisualStyleBackColor = false;
            this.VerenArabtn.Click += new System.EventHandler(this.VerenArabtn_Click);
            // 
            // VerenKodBultxt
            // 
            this.VerenKodBultxt.Location = new System.Drawing.Point(93, 75);
            this.VerenKodBultxt.Name = "VerenKodBultxt";
            this.VerenKodBultxt.Size = new System.Drawing.Size(147, 20);
            this.VerenKodBultxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kitabı Veren :";
            // 
            // ÖdünçVerbtn
            // 
            this.ÖdünçVerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.ÖdünçVerbtn.Location = new System.Drawing.Point(93, 162);
            this.ÖdünçVerbtn.Name = "ÖdünçVerbtn";
            this.ÖdünçVerbtn.Size = new System.Drawing.Size(147, 31);
            this.ÖdünçVerbtn.TabIndex = 11;
            this.ÖdünçVerbtn.Text = "ÖDÜNÇ VER";
            this.ÖdünçVerbtn.UseVisualStyleBackColor = false;
            this.ÖdünçVerbtn.Click += new System.EventHandler(this.ÖdünçVerbtn_Click);
            // 
            // Ödünç_Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ÖdünçVerbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VerenArabtn);
            this.Controls.Add(this.VerenKodBultxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KitapAratxt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Arabtn);
            this.Controls.Add(this.KodBultxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ödünç_Ver";
            this.Text = "Ödünç_Ver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ödünç_Ver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KodBultxt;
        private System.Windows.Forms.Button Arabtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox KitapAratxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button VerenArabtn;
        private System.Windows.Forms.TextBox VerenKodBultxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ÖdünçVerbtn;
    }
}