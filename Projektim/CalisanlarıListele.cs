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
    public partial class CalisanlarıListele : Form
    {
        public CalisanlarıListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=5CG82839QG\SQLEXPRESS;Initial Catalog=Ford;Persist Security Info=True;User ID=sa;Password=123");
        private void CalisanlarıListele_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from CalisanBilgileri", baglanti);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            this.Hide();
            anasayfa.Show();
        }
    }
}
