using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektim
{
    public partial class CalisanCikart : Form
    {
        public CalisanCikart()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=5CG82839QG\SQLEXPRESS;Initial Catalog=Ford;Persist Security Info=True;User ID=sa;Password=123");
        private void CalisanCikart_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from CalisanBilgileri", baglanti);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Alındı!" + ex.Message);
            }
            finally { baglanti.Close(); }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            string ID = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            string isim = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            string soyisim = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            string departman = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            string maas = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            string cinsiyet = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            string dogumTarihi = dataGridView1.Rows[secim].Cells[6].Value.ToString();

            textBox3.Text = ID;
            calisanekletb.Text = isim;
            textBox1.Text = soyisim;
            textBox2.Text = departman;
            textBox4.Text = maas;
            comboBox1.Text = cinsiyet;
            dateTimePicker1.Text = dogumTarihi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || calisanekletb.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Lütfen Veri Seçiniz.");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sil = new SqlCommand("delete from CalisanBilgileri where ID=@p1", baglanti);
                    sil.Parameters.AddWithValue("p1", textBox3.Text);
                    sil.ExecuteNonQuery();

                    MessageBox.Show("Çalışan Kaydı Silindi");
                    ekraniYenile();
                    textboxlarıBosalt();

                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Alındı!" + ex.Message);
                }
                finally { baglanti.Close(); }
            }


        }
        public void ekraniYenile()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from CalisanBilgileri", baglanti);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Alındı!" + ex.Message);
            }
            finally { baglanti.Close(); }
        }
        public void textboxlarıBosalt()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            calisanekletb.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            this.Hide();
            anasayfa.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
