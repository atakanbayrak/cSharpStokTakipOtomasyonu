
namespace Proje_2
{
    partial class frmTedarikcidenSiparisRapor
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGunlukRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tüm Kayıtlar Icin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(417, 45);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 35);
            this.btnBul.TabIndex = 8;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 46);
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
            this.dataGridGunlukRapor.Location = new System.Drawing.Point(32, 100);
            this.dataGridGunlukRapor.Name = "dataGridGunlukRapor";
            this.dataGridGunlukRapor.ReadOnly = true;
            this.dataGridGunlukRapor.RowHeadersWidth = 51;
            this.dataGridGunlukRapor.RowTemplate.Height = 24;
            this.dataGridGunlukRapor.Size = new System.Drawing.Size(957, 423);
            this.dataGridGunlukRapor.TabIndex = 5;
            // 
            // frmTedarikcidenSiparisRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridGunlukRapor);
            this.Name = "frmTedarikcidenSiparisRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTedarikcidenSiparisRapor";
            this.Load += new System.EventHandler(this.frmTedarikcidenSiparisRapor_Load);
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
    }
}