
namespace Proje_2
{
    partial class frmGelirGider
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
            this.btnAna = new System.Windows.Forms.Button();
            this.btnGider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGelir
            // 
            this.btnGelir.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelir.Location = new System.Drawing.Point(157, 179);
            this.btnGelir.Name = "btnGelir";
            this.btnGelir.Size = new System.Drawing.Size(158, 35);
            this.btnGelir.TabIndex = 0;
            this.btnGelir.Text = "Gelir Islemleri";
            this.btnGelir.UseVisualStyleBackColor = true;
            this.btnGelir.Click += new System.EventHandler(this.btnGelir_Click);
            // 
            // btnAna
            // 
            this.btnAna.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAna.Location = new System.Drawing.Point(307, 259);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(176, 35);
            this.btnAna.TabIndex = 1;
            this.btnAna.Text = "Ana Menüye Dön";
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // btnGider
            // 
            this.btnGider.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGider.Location = new System.Drawing.Point(465, 179);
            this.btnGider.Name = "btnGider";
            this.btnGider.Size = new System.Drawing.Size(184, 35);
            this.btnGider.TabIndex = 2;
            this.btnGider.Text = "Gider Islemleri";
            this.btnGider.UseVisualStyleBackColor = true;
            this.btnGider.Click += new System.EventHandler(this.btnGider_Click);
            // 
            // frmGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGider);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.btnGelir);
            this.Name = "frmGelirGider";
            this.Text = "frmGelirGider";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGelir;
        private System.Windows.Forms.Button btnAna;
        private System.Windows.Forms.Button btnGider;
    }
}