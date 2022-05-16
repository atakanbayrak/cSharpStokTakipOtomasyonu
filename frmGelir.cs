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
    public partial class frmGelir : Form
    {
        public frmGelir()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VBC9NOO\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
        DataSet dataSet = new DataSet();
        double tutar=0;
        private void frmGelir_Load(object sender, EventArgs e)
        {
            Gelir_Listele();
        }

        private void Gelir_Listele()
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select tc,tutar,tarih from siparis",connection);
            dataAdapter.Fill(dataSet,"siparis");
            dataGridGelir.DataSource = dataSet.Tables["siparis"];
            connection.Close();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select tutar from siparis",connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                 tutar = tutar + double.Parse(reader["tutar"].ToString());
            }
            reader.Close();
            txtGelir.Text = tutar.ToString();
            connection.Close();
            MessageBox.Show("Hesaplama Yapıldı");
        }
    }
}
