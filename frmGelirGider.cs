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
    public partial class frmGelirGider : Form
    {
        public frmGelirGider()
        {
            InitializeComponent();
        }

        private void btnGider_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGider gider = new frmGider();
            gider.ShowDialog();
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Close();
            frm1.Show();
        }

        private void btnGelir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGelir gelir = new frmGelir();
            gelir.ShowDialog();
        }
    }
}
