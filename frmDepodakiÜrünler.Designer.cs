
namespace Proje_2
{
    partial class frmDepodakiÜrünler
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
            this.dataGripDepodakiÜrünler = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGripDepodakiÜrünler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGripDepodakiÜrünler
            // 
            this.dataGripDepodakiÜrünler.BackgroundColor = System.Drawing.Color.White;
            this.dataGripDepodakiÜrünler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGripDepodakiÜrünler.Location = new System.Drawing.Point(68, 71);
            this.dataGripDepodakiÜrünler.Name = "dataGripDepodakiÜrünler";
            this.dataGripDepodakiÜrünler.RowHeadersWidth = 51;
            this.dataGripDepodakiÜrünler.RowTemplate.Height = 24;
            this.dataGripDepodakiÜrünler.Size = new System.Drawing.Size(1061, 265);
            this.dataGripDepodakiÜrünler.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Önceki Menüye Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDepodakiÜrünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGripDepodakiÜrünler);
            this.Name = "frmDepodakiÜrünler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDepodakiÜrünler";
            this.Load += new System.EventHandler(this.frmDepodakiÜrünler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGripDepodakiÜrünler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGripDepodakiÜrünler;
        private System.Windows.Forms.Button button1;
    }
}