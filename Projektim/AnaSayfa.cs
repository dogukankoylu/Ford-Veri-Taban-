using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektim
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekle ekle = new Ekle();
            this.Hide();
            ekle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalisanCikart calisanCikart = new CalisanCikart();
            this.Hide();
            calisanCikart.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalisanlarıListele calisanlarıListele = new CalisanlarıListele();
            this.Hide();
            calisanlarıListele.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MaasHesaplama maasHesaplama = new MaasHesaplama();
            this.Hide();
            maasHesaplama.Show();
        }
    }
}
