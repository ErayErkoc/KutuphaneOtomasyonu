﻿
namespace KutuphaneOtomasyonu.Kitap
{
    partial class Kitap_Sil
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
            this.KitapSilbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // KitapSilbtn
            // 
            this.KitapSilbtn.Location = new System.Drawing.Point(308, 358);
            this.KitapSilbtn.Name = "KitapSilbtn";
            this.KitapSilbtn.Size = new System.Drawing.Size(175, 42);
            this.KitapSilbtn.TabIndex = 1;
            this.KitapSilbtn.Text = "KİTABI SİL";
            this.KitapSilbtn.UseVisualStyleBackColor = true;
            this.KitapSilbtn.Click += new System.EventHandler(this.KitapSilbtn_Click);
            // 
            // Kitap_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KitapSilbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kitap_Sil";
            this.Text = "Kitap_Sil";
            this.Load += new System.EventHandler(this.Kitap_Sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button KitapSilbtn;
    }
}