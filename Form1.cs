using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMusteri musteri = new frmMusteri();
            musteri.ShowDialog();
        }

        private void btnTedarik_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTedarik tedarik = new frmTedarik();
            tedarik.ShowDialog();
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGelirGider gelirGider = new frmGelirGider();
            gelirGider.ShowDialog();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStok stok = new frmStok();
            stok.ShowDialog();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSiparis siparis = new frmSiparis();
            siparis.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRapor rapor = new frmRapor();
            rapor.ShowDialog();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
