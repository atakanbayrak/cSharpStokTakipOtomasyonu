
namespace Proje_2
{
    partial class frmGelir
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
            this.dataGridGelir = new System.Windows.Forms.DataGridView();
            this.txtGelir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGelir)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGelir
            // 
            this.dataGridGelir.AllowUserToAddRows = false;
            this.dataGridGelir.AllowUserToDeleteRows = false;
            this.dataGridGelir.AllowUserToResizeColumns = false;
            this.dataGridGelir.AllowUserToResizeRows = false;
            this.dataGridGelir.BackgroundColor = System.Drawing.Color.White;
            this.dataGridGelir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGelir.Location = new System.Drawing.Point(37, 47);
            this.dataGridGelir.Name = "dataGridGelir";
            this.dataGridGelir.ReadOnly = true;
            this.dataGridGelir.RowHeadersWidth = 51;
            this.dataGridGelir.RowTemplate.Height = 24;
            this.dataGridGelir.Size = new System.Drawing.Size(454, 280);
            this.dataGridGelir.TabIndex = 0;
            // 
            // txtGelir
            // 
            this.txtGelir.Location = new System.Drawing.Point(680, 47);
            this.txtGelir.Name = "txtGelir";
            this.txtGelir.Size = new System.Drawing.Size(100, 22);
            this.txtGelir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam Anlık Gelir";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(538, 285);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(154, 42);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Anlık Gelir Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // frmGelir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 391);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGelir);
            this.Controls.Add(this.dataGridGelir);
            this.Name = "frmGelir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGelir";
            this.Load += new System.EventHandler(this.frmGelir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGelir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGelir;
        private System.Windows.Forms.TextBox txtGelir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapla;
    }
}