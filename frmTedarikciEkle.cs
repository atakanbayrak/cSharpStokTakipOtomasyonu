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
    public partial class frmTedarikciEkle : Form
    {
        public frmTedarikciEkle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VBC9NOO\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
        bool condition=true;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmTedarik frmTedarik = new frmTedarik();
            this.Close();
            frmTedarik.Show();
        }

        private void frmTedarikciEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            firmaNo_Engelle();
            if(condition == true)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into tedarik(firmano,firmaadı,firmatel,firmamail,firmaadres,cocukgiyim,kadıngiyim,erkekgiyim) values(@firmano,@firmaadı,@firmatel,@firmamail,@firmaadres,@cocukgiyim,@kadıngiyim,@erkekgiyim) ", connection);
                command.Parameters.AddWithValue("@firmano", txtFirmaNo.Text);
                command.Parameters.AddWithValue("@firmaadı", txtFirmaAd.Text);
                command.Parameters.AddWithValue("@firmatel", txtFirmaTel.Text);
                command.Parameters.AddWithValue("@firmamail", txtFirmaMail.Text);
                command.Parameters.AddWithValue("@firmaadres", txtFirmaAdres.Text);
                command.Parameters.AddWithValue("@cocukgiyim", chcCocuk.Checked);
                command.Parameters.AddWithValue("@kadıngiyim", chcKadin.Checked);
                command.Parameters.AddWithValue("@erkekgiyim", chcErkek.Checked);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Tedarikçi Başarıyla Eklendi !");
            }
            else
            {
                MessageBox.Show("Barkod Kodu Aynı Ya Da Boş Olamaz !");
                condition = true;
            }
            foreach (Control controls in groupBox1.Controls)
            {
                if (controls is TextBox)
                {
                    controls.Text = "";
                }
            }

        }
        private void firmaNo_Engelle()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select *from tedarik", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (txtFirmaNo.Text == dataReader["firmano"].ToString() || txtFirmaNo.Text == "")
                {
                    condition = false;
                }
            }
            connection.Close();
        }
        private void txtFirmaNo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
