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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projektim
{
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=5CG82839QG\SQLEXPRESS;Initial Catalog=Ford;Persist Security Info=True;User ID=sa;Password=123");


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || calisanekletb.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Eksik Bilgi Girildi.");

                }
                else
                {
                    SqlCommand ekle = new SqlCommand("insert into CalisanBilgileri(İsim,Soyisim,Departman,Maaş,Cinsiyet,DoğumTarihi) Values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                    ekle.Parameters.AddWithValue("@p1", calisanekletb.Text);
                    ekle.Parameters.AddWithValue("@p2", textBox1.Text);
                    ekle.Parameters.AddWithValue("@p3", textBox2.Text);
                    ekle.Parameters.AddWithValue("@p4", textBox3.Text);
                    ekle.Parameters.AddWithValue("@p5", comboBox1.Text);
                    ekle.Parameters.AddWithValue("@p6", dateTimePicker1.Text);

                    ekle.ExecuteNonQuery();


                    MessageBox.Show("Çalışan Eklendi");
                    textboxlarıBosalt();

                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Alındı!" + ex.Message);
            }
            finally
            { baglanti.Close(); }
        }
        public void textboxlarıBosalt()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            calisanekletb.Text = "";
            comboBox1.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.ShowDialog();
        }
    }

}
