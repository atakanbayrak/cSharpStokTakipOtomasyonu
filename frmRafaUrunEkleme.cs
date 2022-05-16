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
    public partial class frmRafaUrunEkleme : Form
    {
        public frmRafaUrunEkleme()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VBC9NOO\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
        DataSet dataSet = new DataSet();
        bool condition=true;
        bool conditionAmount = false;
        double depodakiMiktar=0;
        private void frmRafaUrunEkleme_Load(object sender, EventArgs e)
        {
            Urun_Listele();
            txtBarkodNo.ReadOnly = true;
            txtKategori.ReadOnly = true;
            txtMiktar.ReadOnly = true;
            txtTedarikci.ReadOnly = true;
            txtUrunAdi.ReadOnly = true;
        }
        private void Urun_Listele()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from depoStok", connection);
            adtr.Fill(dataSet, "depoStok");
            dataGridDepoUrun.DataSource = dataSet.Tables["depoStok"];
            connection.Close();
        }

        private void dataGridDepoUrun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkodNo.Text = dataGridDepoUrun.CurrentRow.Cells["barkodno"].Value.ToString();
            txtUrunAdi.Text = dataGridDepoUrun.CurrentRow.Cells["ürünadi"].Value.ToString();
            txtMiktar.Text = dataGridDepoUrun.CurrentRow.Cells["miktar"].Value.ToString();
            txtTedarikci.Text = dataGridDepoUrun.CurrentRow.Cells["tedarikci"].Value.ToString();
            txtKategori.Text = dataGridDepoUrun.CurrentRow.Cells["ürünkategorisi"].Value.ToString();
            depodakiMiktar = double.Parse(txtMiktar.Text);
            
            /*txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();*/

        }
        private void Miktar_Kontrol()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select *from rafStok where barkodno like '"+txtBarkodNo.Text+"' and tedarikci= '"+txtTedarikci.Text+"' ",connection);
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
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            Miktar_Kontrol();
            if(condition == false)
            {
                connection.Open();
                SqlCommand command6 = new SqlCommand("select *from depoStok where barkodno like '" + txtBarkodNo.Text + "' and tedarikci = '"+txtTedarikci.Text+"'  ", connection);
                SqlDataReader dataRead = command6.ExecuteReader();
                while (dataRead.Read())
                {
                    if (double.Parse(txtEklenecekMiktar.Text) < double.Parse(dataRead["miktar"].ToString()))
                    {
                        conditionAmount = true;
                    }
                }
                connection.Close();
                dataRead.Close();
                if (conditionAmount == true)
                {
                    connection.Open();
                    SqlCommand command4 = new SqlCommand("update rafStok set miktar = miktar+'" + double.Parse(txtEklenecekMiktar.Text) + "' where barkodno = '"+txtBarkodNo.Text+"' and tedarikci = '"+txtTedarikci.Text+"' ", connection);
                    command4.ExecuteNonQuery();
                    SqlCommand command5 = new SqlCommand("update depoStok set miktar = miktar-'" + double.Parse(txtEklenecekMiktar.Text) + "' where barkodno = '"+txtBarkodNo.Text+"' and tedarikci = '"+txtTedarikci.Text+"' ", connection);
                    command5.ExecuteNonQuery();
                    MessageBox.Show("Var Olan Ürünün üstüne eklendi");
                    dataSet.Tables["depoStok"].Clear();
                    connection.Close();
                    conditionAmount = false;
                    Urun_Listele();
                }
                else
                {
                    MessageBox.Show("Eklemek İstediğiniz Ürün kadar Depoda Ürün yok");
                }
            }
            else
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("select *from depoStok where barkodno like '"+txtBarkodNo.Text+"' and tedarikci = '"+txtTedarikci.Text+"' ",connection);
                SqlDataReader dataRead = command1.ExecuteReader();
                while (dataRead.Read())
                {
                    if(double.Parse(txtEklenecekMiktar.Text) < double.Parse(dataRead["miktar"].ToString()))
                    {
                        conditionAmount = true;
                    }
                }
                dataRead.Close();
                connection.Close();
                if (conditionAmount == true)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into rafStok(barkodno,ürünadi,ürünkategorisi,tedarikci,miktar) values(@barkodno,@ürünadi,@ürünkategorisi,@tedarikci,@miktar)", connection);
                    command.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                    command.Parameters.AddWithValue("@ürünadi", txtUrunAdi.Text);
                    command.Parameters.AddWithValue("@miktar", double.Parse(txtEklenecekMiktar.Text));
                    command.Parameters.AddWithValue("@tedarikci", txtTedarikci.Text);
                    command.Parameters.AddWithValue("@ürünkategorisi", txtKategori.Text);
                    command.ExecuteNonQuery();
                        
                    MessageBox.Show("Ürün Rafa Eklendi");
                    SqlCommand command2 = new SqlCommand("update depoStok set miktar = miktar-'" + double.Parse(txtEklenecekMiktar.Text) + "' where barkodno = '" + txtBarkodNo.Text + "' and tedarikci = '" + txtTedarikci.Text + "'  ", connection);
                    command2.ExecuteNonQuery();
                    dataSet.Tables["depoStok"].Clear();
                    connection.Close();
                    Urun_Listele();
                }
                else
                {
                    MessageBox.Show("Eklemek İstediğiniz Ürün kadar Depoda Ürün yok");
                }
            }
        }
    }
}
