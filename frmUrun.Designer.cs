
namespace Proje_2
{
    partial class frmUrun
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtUrünAdi = new System.Windows.Forms.TextBox();
            this.txtUrünBarkod = new System.Windows.Forms.TextBox();
            this.txtAlis = new System.Windows.Forms.TextBox();
            this.txtSatis = new System.Windows.Forms.TextBox();
            this.grpBoxUrünEkle = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpBoxUrünEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urun Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Urün Barkod Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Urün Kategorisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Urün Alıs Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Urün Satıs Fiyatı";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Kadin Giyim",
            "Erkek Giyim",
            "Cocuk Giyim"});
            this.cmbKategori.Location = new System.Drawing.Point(330, 141);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(183, 33);
            this.cmbKategori.TabIndex = 5;
            // 
            // txtUrünAdi
            // 
            this.txtUrünAdi.Location = new System.Drawing.Point(330, 53);
            this.txtUrünAdi.Name = "txtUrünAdi";
            this.txtUrünAdi.Size = new System.Drawing.Size(183, 32);
            this.txtUrünAdi.TabIndex = 6;
            // 
            // txtUrünBarkod
            // 
            this.txtUrünBarkod.Location = new System.Drawing.Point(330, 97);
            this.txtUrünBarkod.Name = "txtUrünBarkod";
            this.txtUrünBarkod.Size = new System.Drawing.Size(183, 32);
            this.txtUrünBarkod.TabIndex = 7;
            // 
            // txtAlis
            // 
            this.txtAlis.Location = new System.Drawing.Point(330, 187);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(183, 32);
            this.txtAlis.TabIndex = 8;
            // 
            // txtSatis
            // 
            this.txtSatis.Location = new System.Drawing.Point(330, 231);
            this.txtSatis.Name = "txtSatis";
            this.txtSatis.Size = new System.Drawing.Size(183, 32);
            this.txtSatis.TabIndex = 9;
            // 
            // grpBoxUrünEkle
            // 
            this.grpBoxUrünEkle.Controls.Add(this.label7);
            this.grpBoxUrünEkle.Controls.Add(this.label6);
            this.grpBoxUrünEkle.Controls.Add(this.btnEkle);
            this.grpBoxUrünEkle.Controls.Add(this.label1);
            this.grpBoxUrünEkle.Controls.Add(this.txtSatis);
            this.grpBoxUrünEkle.Controls.Add(this.label2);
            this.grpBoxUrünEkle.Controls.Add(this.txtAlis);
            this.grpBoxUrünEkle.Controls.Add(this.label3);
            this.grpBoxUrünEkle.Controls.Add(this.txtUrünBarkod);
            this.grpBoxUrünEkle.Controls.Add(this.label4);
            this.grpBoxUrünEkle.Controls.Add(this.txtUrünAdi);
            this.grpBoxUrünEkle.Controls.Add(this.label5);
            this.grpBoxUrünEkle.Controls.Add(this.cmbKategori);
            this.grpBoxUrünEkle.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxUrünEkle.Location = new System.Drawing.Point(58, 46);
            this.grpBoxUrünEkle.Name = "grpBoxUrünEkle";
            this.grpBoxUrünEkle.Size = new System.Drawing.Size(639, 387);
            this.grpBoxUrünEkle.TabIndex = 10;
            this.grpBoxUrünEkle.TabStop = false;
            this.grpBoxUrünEkle.Text = "Urün Ekleme Formu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "TL";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(206, 305);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 32);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 539);
            this.Controls.Add(this.grpBoxUrünEkle);
            this.Name = "frmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Bilgisi Ekleme";
            this.Load += new System.EventHandler(this.frmUrun_Load);
            this.grpBoxUrünEkle.ResumeLayout(false);
            this.grpBoxUrünEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtUrünAdi;
        private System.Windows.Forms.TextBox txtUrünBarkod;
        private System.Windows.Forms.TextBox txtAlis;
        private System.Windows.Forms.TextBox txtSatis;
        private System.Windows.Forms.GroupBox grpBoxUrünEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}