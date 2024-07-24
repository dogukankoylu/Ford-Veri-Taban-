namespace Projektim
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "0207")
            {
                AnaSayfa anaSayfa = new AnaSayfa();
                this.Hide();
                anaSayfa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yanlýþ Kullanýcý Adý Veya Þifre.");
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
