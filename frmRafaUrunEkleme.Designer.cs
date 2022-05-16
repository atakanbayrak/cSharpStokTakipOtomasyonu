
namespace Proje_2
{
    partial class frmRafaUrunEkleme
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
            this.dataGridDepoUrun = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtTedarikci = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEklenecekMiktar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepoUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDepoUrun
            // 
            this.dataGridDepoUrun.AllowUserToAddRows = false;
            this.dataGridDepoUrun.AllowUserToDeleteRows = false;
            this.dataGridDepoUrun.AllowUserToResizeColumns = false;
            this.dataGridDepoUrun.AllowUserToResizeRows = false;
            this.dataGridDepoUrun.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDepoUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDepoUrun.Location = new System.Drawing.Point(33, 91);
            this.dataGridDepoUrun.Name = "dataGridDepoUrun";
            this.dataGridDepoUrun.ReadOnly = true;
            this.dataGridDepoUrun.RowHeadersWidth = 51;
            this.dataGridDepoUrun.RowTemplate.Height = 24;
            this.dataGridDepoUrun.Size = new System.Drawing.Size(597, 302);
            this.dataGridDepoUrun.TabIndex = 0;
            this.dataGridDepoUrun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDepoUrun_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rafa Eklemek İstediğiniz Ürüne Çift Tıklayınız";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(817, 91);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 22);
            this.txtBarkodNo.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(817, 132);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(817, 173);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(100, 22);
            this.txtKategori.TabIndex = 4;
            // 
            // txtTedarikci
            // 
            this.txtTedarikci.Location = new System.Drawing.Point(816, 214);
            this.txtTedarikci.Name = "txtTedarikci";
            this.txtTedarikci.Size = new System.Drawing.Size(101, 22);
            this.txtTedarikci.TabIndex = 5;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(817, 255);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 22);
            this.txtMiktar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Barkod No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tedarikci";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(719, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Miktar";
            // 
            // txtEklenecekMiktar
            // 
            this.txtEklenecekMiktar.Location = new System.Drawing.Point(816, 296);
            this.txtEklenecekMiktar.Name = "txtEklenecekMiktar";
            this.txtEklenecekMiktar.Size = new System.Drawing.Size(100, 22);
            this.txtEklenecekMiktar.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rafa Eklenecek Miktar";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(817, 359);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(99, 34);
            this.btnOnayla.TabIndex = 14;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // frmRafaUrunEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 522);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEklenecekMiktar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtTedarikci);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDepoUrun);
            this.Name = "frmRafaUrunEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRafaUrunEkleme";
            this.Load += new System.EventHandler(this.frmRafaUrunEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepoUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDepoUrun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtTedarikci;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEklenecekMiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOnayla;
    }
}