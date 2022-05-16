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
    public partial class frmGider : Form
    {
        public frmGider()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VBC9NOO\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmGelirGider frmGelirGider = new frmGelirGider();
            this.Close();
            frmGelirGider.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            String tarih = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into gider(gidercesidi,toplamücret,tarih) values(@gidercesidi,@toplamücret,@tarih)", connection);
            command.Parameters.AddWithValue("@gidercesidi", cmbGider.Text);
            command.Parameters.AddWithValue("@toplamücret", txtUcret.Text);
            command.Parameters.Add("@tarih", System.Data.SqlDbType.VarChar).Value = tarih;
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Gider Başarıyla Kaydedildi !");
            foreach (Control controls in groupBox1.Controls)
            {
                if (controls is TextBox)
                {
                    controls.Text = "";
                }
                if (controls is ComboBox)
                {
                    controls.Text = "";
                }
            }
        }
    }
}
