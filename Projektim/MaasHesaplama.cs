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
    public partial class MaasHesaplama : Form
    {
        public MaasHesaplama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=5CG82839QG\SQLEXPRESS;Initial Catalog=Ford;Persist Security Info=True;User ID=sa;Password=123");
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                baglanti.Open();
                SqlCommand yazılımMaas = new SqlCommand("Select SUM(maaş) from CalisanBilgileri where departman='Yazılım'", baglanti);
                SqlDataReader sdr = yazılımMaas.ExecuteReader();
                while (sdr.Read())
                {
                    textBox1.Text = sdr[0].ToString();
                }
                sdr.Close();

                SqlDataAdapter yazılımcılar = new SqlDataAdapter("select * from CalisanBilgileri where departman='Yazılım'", baglanti);
                DataSet ds = new DataSet();
                yazılımcılar.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlCommand ik = new SqlCommand("Select SUM(maaş) from CalisanBilgileri where departman='IK'", baglanti);
                SqlDataReader sdr = ik.ExecuteReader();
                while (sdr.Read())
                {
                    textBox1.Text = sdr[0].ToString();
                }
                sdr.Close();

                SqlDataAdapter ikcilar = new SqlDataAdapter("select * from CalisanBilgileri where departman='IK'", baglanti);
                DataSet ds = new DataSet();
                ikcilar.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlCommand finans = new SqlCommand("select sum(maaş) from CalisanBilgileri where departman='Finans'", baglanti);
                SqlDataReader sdr = finans.ExecuteReader();
                while (sdr.Read())
                {
                    textBox1.Text = sdr[0].ToString();
                }
                sdr.Close();

                SqlDataAdapter finanscilar = new SqlDataAdapter("Select * from CalisanBilgileri where departman='Finans'", baglanti);
                DataSet ds = new DataSet();
                finanscilar.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                baglanti.Open();
                SqlCommand tumu = new SqlCommand("select sum(maaş) from CalisanBilgileri", baglanti);
                SqlDataReader sdr = tumu.ExecuteReader();
                while (sdr.Read())
                {
                    textBox1.Text = sdr[0].ToString();
                }
                sdr.Close();

                SqlDataAdapter tum = new SqlDataAdapter("Select * from CalisanBilgileri", baglanti);
                DataSet ds = new DataSet();
                tum.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.Show();
        }
    }
}
