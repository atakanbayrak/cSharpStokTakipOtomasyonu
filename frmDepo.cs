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
    public partial class frmDepo : Form
    {
        public frmDepo()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VBC9NOO\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
      
        bool cocukGiyim = true;
        bool kadinGiyim = true;
        bool erkekGiyim = true;
        bool condition = true;
        private void txtBarkodNoBul_TextChanged(object sender, EventArgs e)
        {
            foreach (Control controls in Controls)
            {
                if (controls is TextBox)
                {
                    controls.Text = "";
                }
            }
            cmbKategori.Items.Clear();
            cmbKategori.Text = "";
            cmbTedarik.Items.Clear();
            cmbTedarik.Text = "";

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("select *from ürün where barkodno like'" + txtBarkodNoBul.Text + "'", connection);
            SqlDataReader dataRead = command.ExecuteReader();
            if (txtBarkodNoBul.Text == "")
            {
                foreach (Control controls in Controls)
                {
                    if (controls is TextBox)
                    {
                        controls.Text = "";
                    }
                }
            }
            while (dataRead.Read())
            {
                txtÜrünAdı.Text = dataRead["ürünadı"].ToString();
                cmbKategori.Items.Add(dataRead["kategori"].ToString());
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("select *from ürün where barkodno like'" + txtBarkodNoBul.Text + "'", connection);
            SqlDataReader dataRead = command.ExecuteReader();
            if (txtBarkodNoBul.Text == "")
            {
                foreach (Control controls in Controls)
                {
                    if (controls is TextBox)
                    {
                        controls.Text = "";
                    }
                }
            }
            while (dataRead.Read())
            {
                txtÜrünAdı.Text = dataRead["ürünadı"].ToString();
                cmbKategori.Items.Add(dataRead["kategori"].ToString());
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        private void Miktar_Kontrol()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select *from depoStok where barkodno like '" + txtBarkodNoBul.Text + "' and tedarikci = '"+cmbTedarik.SelectedItem+"' ", connection);
            SqlDataReader dataRead = command.ExecuteReader();
            while (dataRead.Read())
            {
                if (dataRead["miktar"].ToString() != "0")
                {
                    condition = false;
                }
                else condition = true;
            }
            dataRead.Close();
            connection.Close();
        }
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            String tarih = DateTime.Now.ToString("dd/MM/yyyy");
            Miktar_Kontrol();
            if (condition == false)
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("update depoStok set miktar = miktar+'"+double.Parse(txtMiktar.Text)+"' where barkodno= '"+txtBarkodNoBul.Text+"' and tedarikci= '"+cmbTedarik.SelectedItem   +"' ",connection);
                command1.ExecuteNonQuery();
                SqlCommand command2 = new SqlCommand("insert into gider(gidercesidi,toplamücret,tarih) values(@gidercesidi,@toplamücret,@tarih) ", connection);
                command2.Parameters.AddWithValue("@gidercesidi", "Kıyafet Siparişi");
                command2.Parameters.AddWithValue("@toplamücret", txtTutar.Text);
                command2.Parameters.AddWithValue("@tarih", tarih);
                command2.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Var Olan Ürünün Üstüne Ekleme Yapıldı");

            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into depoStok(barkodno,ürünadi,ürünkategorisi,tedarikci,miktar,tutar,tarih) values(@barkodno,@ürünadi,@ürünkategorisi,@tedarikci,@miktar,@tutar,@tarih)", connection);
                command.Parameters.AddWithValue("@barkodno", txtBarkodNoBul.Text);
                command.Parameters.AddWithValue("@ürünadi", txtÜrünAdı.Text);
                command.Parameters.AddWithValue("@ürünkategorisi", cmbKategori.Text);
                command.Parameters.AddWithValue("@tedarikci", cmbTedarik.Text);
                command.Parameters.AddWithValue("@miktar", double.Parse(txtMiktar.Text));
                command.Parameters.AddWithValue("@tutar", double.Parse(txtTutar.Text));
                command.Parameters.AddWithValue("@tarih", tarih);
                command.ExecuteNonQuery();
                SqlCommand command2 = new SqlCommand("insert into gider(gidercesidi,toplamücret,tarih) values(@gidercesidi,@toplamücret,@tarih) ", connection);
                command2.Parameters.AddWithValue("@gidercesidi", "Kıyafet Siparişi");
                command2.Parameters.AddWithValue("@toplamücret", txtTutar.Text);
                command2.Parameters.AddWithValue("@tarih", tarih);
                connection.Close();
                MessageBox.Show("Siparişiniz Başarı İle Oluşturuldu !");
            }
            foreach (Control controls in groupBox2.Controls)
            {
                if(controls is TextBox)
                {
                    controls.Text = "";
                }
                if(controls is ComboBox)
                {
                    controls.Text = "";
                }
            }
            foreach (Control controls in grpBoxBilgi.Controls)
            {
                if (controls is TextBox)
                {
                    controls.Text = "";
                }
            }
        }
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            cmbTedarik.Items.Clear();
            cmbTedarik.Text = "";

            SqlCommand command = new SqlCommand("select *from tedarik ", connection);
            SqlDataReader dataRead = command.ExecuteReader();

            while (dataRead.Read())
            {
                if (int.Parse(dataRead["cocukgiyim"].ToString()) == 1)
                {
                    cocukGiyim = true;
                    if (cmbKategori.SelectedItem.ToString() == "Cocuk Giyim")
                    {
                        cmbTedarik.Items.Add(dataRead["firmaadı"].ToString());
                    }
                }
                if (int.Parse(dataRead["kadıngiyim"].ToString()) == 1)
                {
                    kadinGiyim = true;
                    if (cmbKategori.SelectedItem.ToString() == "Kadin Giyim")
                    {
                        cmbTedarik.Items.Add(dataRead["firmaadı"].ToString());
                        
                    }
                }
                if (int.Parse(dataRead["erkekgiyim"].ToString()) == 1)
                {
                    erkekGiyim = true;
                    if (cmbKategori.SelectedItem.ToString() == "Erkek Giyim")
                    {
                        cmbTedarik.Items.Add(dataRead["firmaadı"].ToString());
                    }
                }
            }
            dataRead.Close();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void txtMiktar_TextChanged_1(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("select *from ürün where barkodno like'" + txtBarkodNoBul.Text + "' ", connection);
            SqlDataReader dataRead = command.ExecuteReader();
            while (dataRead.Read())
            {
                double alisFiyati = double.Parse(dataRead["alısfiyati"].ToString());
                if (txtMiktar.Text == "")
                {
                    txtTutar.Text = "0";
                }
                else
                {
                    txtTutar.Text = (alisFiyati * double.Parse(txtMiktar.Text)).ToString();
                }
                

                
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void frmDepo_Load(object sender, EventArgs e)
        {
            txtTutar.ReadOnly = true;
        }

        
    }
}
