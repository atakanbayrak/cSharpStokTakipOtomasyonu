using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_2
{
    public partial class frmDepodakiÜrünler : Form
    {
        public frmDepodakiÜrünler()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VBC9NOO\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
        DataSet dataSet = new DataSet();
        private void frmDepodakiÜrünler_Load(object sender, EventArgs e)
        {
            Depo_Listele();
        }

        private void Depo_Listele()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from depoStok", connection);
            adtr.Fill(dataSet, "depoStok");
            dataGripDepodakiÜrünler.DataSource = dataSet.Tables["depoStok"];
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRapor rapor = new frmRapor();
            this.Close();
            rapor.Show();
        }
    }
}
