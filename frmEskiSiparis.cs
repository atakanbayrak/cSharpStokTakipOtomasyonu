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
    public partial class frmEskiSiparis : Form
    {
        public frmEskiSiparis()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VBC9NOO\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
        bool condition = false;
        double amount = 0;
        private void frmSiparis_Load(object sender, EventArgs e)
        {
            txtAdSoyad.ReadOnly = true;
            txtTelefon.ReadOnly = true;
            txtAdres.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtUrunAdi.ReadOnly = true;
            txtKategori.ReadOnly = true;
            txtTedarikci.ReadOnly = true;
            txtMevcutMiktar.ReadOnly = true;
            txtTutar.ReadOnly = true;
            txtFiyat.ReadOnly = true;
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control controls in Controls)
                {
                    if (controls is TextBox)
                    {
                        controls.Text = "";
                    }
                }
            }
            if(txtBarkodNo.Text != "")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select *from rafStok where barkodno like '" + txtBarkodNo.Text + "'", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtUrunAdi.Text = reader["ürünadi"].ToString();
                    txtKategori.Text = reader["ürünkategorisi"].ToString();
                    txtTedarikci.Text = reader["tedarikci"].ToString();
                    txtMevcutMiktar.Text = reader["miktar"].ToString();
                }
                reader.Close();
                SqlCommand command2 = new SqlCommand("select satısfiyati from ürün where barkodno like '" + txtBarkodNo.Text + "'", connection);
                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    txtFiyat.Text = reader2["satısfiyati"].ToString();
                }
                reader2.Close();
                connection.Close();
            }
            
            
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                foreach (Control controls in Controls)
                {
                    if (controls is TextBox)
                    {
                        controls.Text = "";
                    }
                }
            }
            if(txtTc.Text != "")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select *from musteri_ekle where tc like '" + txtTc.Text + "'", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtAdSoyad.Text = reader["adsoyad"].ToString();
                    txtTelefon.Text = reader["telefon"].ToString();
                    txtAdres.Text = reader["adres"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                }
                reader.Close();
                connection.Close();
            }
            
        }

        private void txtIstenenMiktar_TextChanged(object sender, EventArgs e)
        {
            if (txtIstenenMiktar.Text != "")
            {
                connection.Open();
                SqlCommand command3 = new SqlCommand("select *from ürün where barkodno like '" + txtBarkodNo.Text + "'", connection);
                SqlDataReader reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                    if (txtIstenenMiktar.Text != "")
                    {
                        double satisFiyati = double.Parse(reader3["satısfiyati"].ToString());
                        txtTutar.Text = (satisFiyati * double.Parse(txtIstenenMiktar.Text)).ToString();
                    }
                }
                reader3.Close();
                connection.Close();
            }
            if (txtIstenenMiktar.Text == "")
            {
                txtTutar.Text = "0";
            }
        }
        private void Miktar_Kontrol()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select *from rafStok where barkodno like '" + txtBarkodNo.Text + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                amount =double.Parse(reader["miktar"].ToString());
            }
            if(amount == 0)
            {
                condition = false;
            }
            if (double.Parse(txtIstenenMiktar.Text) < amount)
            {
                condition = true;
            }
            if (double.Parse(txtIstenenMiktar.Text) > amount)
            {
                condition = false;
            }
            reader.Close();
            connection.Close();
        }
        private void btnOnay_Click(object sender, EventArgs e)
        {
            String tarih = DateTime.Now.ToString("dd/MM/yyyy"); 
            Miktar_Kontrol();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            if (condition == true)
            { 
                SqlCommand command = new SqlCommand("insert into siparis(tc,adsoyad,telefon,adres,email,barkodno,ürünadi,ürünkategorisi,tedarikci,miktar,tutar,tarih) values(@tc,@adsoyad,@telefon,@adres,@email,@barkodno,@ürünadi,@ürünkategorisi,@tedarikci,@miktar,@tutar,@tarih)", connection);
                command.Parameters.AddWithValue("@tc", txtTc.Text);
                command.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                command.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                command.Parameters.AddWithValue("@adres", txtAdres.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                command.Parameters.AddWithValue("@ürünadi", txtUrunAdi.Text);
                command.Parameters.AddWithValue("@ürünkategorisi", txtKategori.Text);
                command.Parameters.AddWithValue("@tedarikci", txtTedarikci.Text);
                command.Parameters.AddWithValue("@miktar", double.Parse(txtIstenenMiktar.Text));
                command.Parameters.AddWithValue("@tutar", double.Parse(txtTutar.Text));
                command.Parameters.AddWithValue("@tarih", tarih);
                command.ExecuteNonQuery();
                MessageBox.Show("Sipariş Başarı İle Alındı");
                SqlCommand command2 = new SqlCommand("update rafStok set miktar=miktar-'"+double.Parse(txtIstenenMiktar.Text)+"'",connection);
                command2.ExecuteNonQuery();

                foreach (Control controls in this.Controls)
                {
                    if (controls is TextBox)
                    {
                        controls.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Istenilen kadar ürün elde bulunmamaktadır");
                foreach (Control controls in this.Controls)
                {
                    if (controls is TextBox)
                    {
                        controls.Text = "";
                    }
                }
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
