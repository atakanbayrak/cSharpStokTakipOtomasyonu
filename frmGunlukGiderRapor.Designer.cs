
namespace Proje_2
{
    partial class frmGunlukGiderRapor
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
            this.dataGridGunlukRapor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGider = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGunlukRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tüm Kayıtlar Icin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(422, 44);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 35);
            this.btnBul.TabIndex = 8;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dataGridGunlukRapor
            // 
            this.dataGridGunlukRapor.AllowUserToAddRows = false;
            this.dataGridGunlukRapor.AllowUserToDeleteRows = false;
            this.dataGridGunlukRapor.AllowUserToResizeColumns = false;
            this.dataGridGunlukRapor.AllowUserToResizeRows = false;
            this.dataGridGunlukRapor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridGunlukRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGunlukRapor.Location = new System.Drawing.Point(37, 99);
            this.dataGridGunlukRapor.Name = "dataGridGunlukRapor";
            this.dataGridGunlukRapor.ReadOnly = true;
            this.dataGridGunlukRapor.RowHeadersWidth = 51;
            this.dataGridGunlukRapor.RowTemplate.Height = 24;
            this.dataGridGunlukRapor.Size = new System.Drawing.Size(479, 423);
            this.dataGridGunlukRapor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Seçilen Güne Ait Gider";
            // 
            // txtGider
            // 
            this.txtGider.Location = new System.Drawing.Point(542, 196);
            this.txtGider.Name = "txtGider";
            this.txtGider.Size = new System.Drawing.Size(100, 22);
            this.txtGider.TabIndex = 18;
            // 
            // frmGunlukGiderRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGider);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridGunlukRapor);
            this.Name = "frmGunlukGiderRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGunlukGiderRapor";
            this.Load += new System.EventHandler(this.frmGunlukGiderRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGunlukRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridGunlukRapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGider;
    }
}