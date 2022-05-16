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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VBC9NOO\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteri frmMusteri = new frmMusteri();
            this.Close();
            frmMusteri.Show();
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into musteri_ekle(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)", connection);
            command.Parameters.AddWithValue("@tc",txtTc.Text);
            command.Parameters.AddWithValue("@adsoyad", txtAdSoayd.Text);
            command.Parameters.AddWithValue("@telefon", txtTel.Text);
            command.Parameters.AddWithValue("@email", txtMail.Text);
            command.Parameters.AddWithValue("@adres", txtAdres.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri Başarıyla Kaydedildi !");
            foreach(Control controls in this.Controls)
            {
                if(controls is TextBox )
                {
                    controls.Text = "";
                }
            }
        }
    }
}
