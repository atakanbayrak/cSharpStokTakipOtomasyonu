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
    public partial class frmGunlukGelirGiderRaporu : Form
    {
        public frmGunlukGelirGiderRaporu()
        {
            InitializeComponent();
        }

        private void btnGider_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGunlukGiderRapor gunlukGiderRapor = new frmGunlukGiderRapor();
            gunlukGiderRapor.ShowDialog();
        }

        private void btnGelir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGunlukGelirRapor gunlukGelirRapor = new frmGunlukGelirRapor();
            gunlukGelirRapor.ShowDialog();
        }
    }
}
