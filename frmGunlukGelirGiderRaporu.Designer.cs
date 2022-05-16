
namespace Proje_2
{
    partial class frmGunlukGelirGiderRaporu
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
            this.btnGelir = new System.Windows.Forms.Button();
            this.btnGider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGelir
            // 
            this.btnGelir.Location = new System.Drawing.Point(59, 53);
            this.btnGelir.Name = "btnGelir";
            this.btnGelir.Size = new System.Drawing.Size(118, 47);
            this.btnGelir.TabIndex = 0;
            this.btnGelir.Text = "Gelir";
            this.btnGelir.UseVisualStyleBackColor = true;
            this.btnGelir.Click += new System.EventHandler(this.btnGelir_Click);
            // 
            // btnGider
            // 
            this.btnGider.Location = new System.Drawing.Point(205, 53);
            this.btnGider.Name = "btnGider";
            this.btnGider.Size = new System.Drawing.Size(118, 47);
            this.btnGider.TabIndex = 1;
            this.btnGider.Text = "Gider";
            this.btnGider.UseVisualStyleBackColor = true;
            this.btnGider.Click += new System.EventHandler(this.btnGider_Click);
            // 
            // frmGunlukGelirGiderRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 174);
            this.Controls.Add(this.btnGider);
            this.Controls.Add(this.btnGelir);
            this.Name = "frmGunlukGelirGiderRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGunlukGelirGiderRaporu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGelir;
        private System.Windows.Forms.Button btnGider;
    }
}