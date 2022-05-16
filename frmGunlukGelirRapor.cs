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
    public partial class frmGunlukGelirRapor : Form
    {
        public frmGunlukGelirRapor()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VBC9NOO\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
        DataSet dataSet = new DataSet();
        string tarih;
        double tutar = 0;

        private void Gunluk_Rapor()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select tc,tutar,tarih from siparis", connection);
            adtr.Fill(dataSet, "siparis");
            dataGridGunlukGelir.DataSource = dataSet.Tables["siparis"];
            connection.Close();
        }
        private void frmGunlukGelirRapor_Load(object sender, EventArgs e)
        {
            Gunluk_Rapor();
            txtGelir.ReadOnly = true;
            txtGelir.Text = "0";
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            tutar = 0;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d.MM.yyyy";
            tarih = dateTimePicker1.Text;
            textBox1.Text = tarih;
            connection.Open();
            dataSet.Tables.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select tc,tutar,tarih from siparis where tarih like '" + tarih + "'", connection);
            adtr.Fill(dataSet, "siparis");
            dataGridGunlukGelir.DataSource = dataSet.Tables["siparis"];
            SqlCommand command = new SqlCommand("select tc,tutar,tarih from siparis where tarih like '" + tarih + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tutar = tutar + double.Parse(reader["tutar"].ToString());
            }
            reader.Close();
            txtGelir.Text = tutar.ToString();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSet.Tables["siparis"].Clear();
            Gunluk_Rapor();
        }


    }
}
