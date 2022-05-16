
namespace Proje_2
{
    partial class frmGunlukGelirRapor
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridGunlukGelir = new System.Windows.Forms.DataGridView();
            this.txtGelir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGunlukGelir)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tüm Kayıtlar Icin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(414, 37);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 35);
            this.btnBul.TabIndex = 13;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dataGridGunlukGelir
            // 
            this.dataGridGunlukGelir.AllowUserToAddRows = false;
            this.dataGridGunlukGelir.AllowUserToDeleteRows = false;
            this.dataGridGunlukGelir.AllowUserToResizeColumns = false;
            this.dataGridGunlukGelir.AllowUserToResizeRows = false;
            this.dataGridGunlukGelir.BackgroundColor = System.Drawing.Color.White;
            this.dataGridGunlukGelir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGunlukGelir.Location = new System.Drawing.Point(29, 103);
            this.dataGridGunlukGelir.Name = "dataGridGunlukGelir";
            this.dataGridGunlukGelir.ReadOnly = true;
            this.dataGridGunlukGelir.RowHeadersWidth = 51;
            this.dataGridGunlukGelir.RowTemplate.Height = 24;
            this.dataGridGunlukGelir.Size = new System.Drawing.Size(942, 427);
            this.dataGridGunlukGelir.TabIndex = 15;
            // 
            // txtGelir
            // 
            this.txtGelir.Location = new System.Drawing.Point(206, 561);
            this.txtGelir.Name = "txtGelir";
            this.txtGelir.ReadOnly = true;
            this.txtGelir.Size = new System.Drawing.Size(100, 22);
            this.txtGelir.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Seçilen Güne Ait Gelir";
            // 
            // frmGunlukGelirRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 636);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGelir);
            this.Controls.Add(this.dataGridGunlukGelir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmGunlukGelirRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGunlukGelirRapor";
            this.Load += new System.EventHandler(this.frmGunlukGelirRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGunlukGelir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridGunlukGelir;
        private System.Windows.Forms.TextBox txtGelir;
        private System.Windows.Forms.Label label1;
    }
}