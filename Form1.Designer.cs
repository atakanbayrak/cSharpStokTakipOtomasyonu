
namespace Proje_2
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
            this.lblMain = new System.Windows.Forms.Label();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnGelirGider = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnTedarik = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(416, 194);
            this.lblMain.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(278, 49);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Hos Geldiniz ...";
            // 
            // btnMusteri
            // 
            this.btnMusteri.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteri.Location = new System.Drawing.Point(94, 303);
            this.btnMusteri.Margin = new System.Windows.Forms.Padding(6);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(230, 38);
            this.btnMusteri.TabIndex = 1;
            this.btnMusteri.Text = "Müsteri Islemleri";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnGelirGider
            // 
            this.btnGelirGider.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelirGider.Location = new System.Drawing.Point(606, 417);
            this.btnGelirGider.Margin = new System.Windows.Forms.Padding(6);
            this.btnGelirGider.Name = "btnGelirGider";
            this.btnGelirGider.Size = new System.Drawing.Size(230, 41);
            this.btnGelirGider.TabIndex = 3;
            this.btnGelirGider.Text = "Gelir ve Gider Islemleri";
            this.btnGelirGider.UseVisualStyleBackColor = true;
            this.btnGelirGider.Click += new System.EventHandler(this.btnGelirGider_Click);
            // 
            // btnStok
            // 
            this.btnStok.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStok.Location = new System.Drawing.Point(242, 417);
            this.btnStok.Margin = new System.Windows.Forms.Padding(6);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(229, 41);
            this.btnStok.TabIndex = 4;
            this.btnStok.Text = "Stok Islemleri";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparis.Location = new System.Drawing.Point(759, 303);
            this.btnSiparis.Margin = new System.Windows.Forms.Padding(6);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(229, 41);
            this.btnSiparis.TabIndex = 5;
            this.btnSiparis.Text = "Siparis Islemleri";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // btnTedarik
            // 
            this.btnTedarik.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTedarik.Location = new System.Drawing.Point(425, 303);
            this.btnTedarik.Margin = new System.Windows.Forms.Padding(6);
            this.btnTedarik.Name = "btnTedarik";
            this.btnTedarik.Size = new System.Drawing.Size(230, 38);
            this.btnTedarik.TabIndex = 2;
            this.btnTedarik.Text = "Tedarikci Islemleri";
            this.btnTedarik.UseVisualStyleBackColor = true;
            this.btnTedarik.Click += new System.EventHandler(this.btnTedarik_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapor.Location = new System.Drawing.Point(425, 511);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(230, 41);
            this.btnRapor.TabIndex = 6;
            this.btnRapor.Text = "Rapor Islemleri";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(407, 584);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(287, 63);
            this.btnCıkıs.TabIndex = 7;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1100, 712);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnGelirGider);
            this.Controls.Add(this.btnTedarik);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.lblMain);
            this.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnGelirGider;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnTedarik;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnCıkıs;
    }
}

