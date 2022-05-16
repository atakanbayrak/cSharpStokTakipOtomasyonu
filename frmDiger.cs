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
    public partial class frmDiger : Form
    {
        public frmDiger()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VBC9NOO\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            frmMusteri frmMusteri = new frmMusteri();
            this.Close();
            frmMusteri.Show();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "")
            {
                foreach (Control controls in Controls)
                {
                    if (controls is TextBox)
                    {
                        controls.Text = "";
                    }
                }
            }
            connection.Open();
            SqlCommand command = new SqlCommand("select *from musteri_ekle where tc like'"+txtTcAra.Text+"'", connection);
            SqlDataReader dataRead = command.ExecuteReader();
            while(dataRead.Read())
            {
                txtAdSoyad.Text = dataRead["adsoyad"].ToString();
                txtTel.Text = dataRead[2].ToString();
                txtMail.Text = dataRead[4].ToString();
                txtAdres.Text = dataRead[3].ToString();
            }
            connection.Close();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "")
            {
                foreach (Control controls in Controls)
                {
                    if (controls is TextBox)
                    {
                        controls.Text = "";
                    }
                }
            }
            connection.Open();
            SqlCommand command = new SqlCommand("select *from musteri_ekle where tc ='" + txtTcAra.Text + "'", connection);
            SqlDataReader dataRead = command.ExecuteReader();
            while (dataRead.Read())
            {
                txtAdSoyad.Text = dataRead["adsoyad"].ToString();
                txtTel.Text = dataRead[2].ToString();
                txtMail.Text = dataRead[4].ToString();
                txtAdres.Text = dataRead[3].ToString();
            }
            dataRead.Close();
            connection.Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update musteri_ekle set adsoyad=@adsoyad, telefon=@telefon, adres=@adres, email=@email where tc= '"+txtTcAra.Text+"'", connection);
            command.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            command.Parameters.AddWithValue("@telefon", txtTel.Text);
            command.Parameters.AddWithValue("@adres", txtAdres.Text);
            command.Parameters.AddWithValue("@email", txtMail.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri Kaydı Başarıyla Güncellendi");
            foreach (Control controls in this.Controls)
            {
                if (controls is TextBox)
                {
                    controls.Text = "";
                }
            }
            foreach (Control controls in groupBox1.Controls)
            {
                if (controls is TextBox)
                {
                    controls.Text = "";
                }
            }
        }
    }
}
