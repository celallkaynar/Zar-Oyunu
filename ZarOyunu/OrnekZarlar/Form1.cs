namespace OrnekZarlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            buttonZar.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int zar1, zar2;
            Random rastgele = new Random();
            zar1 = rastgele.Next(0, 6);
            zar2 = rastgele.Next(0, 6);
            pictureBox1.Image = ýmageList1.Images[zar1];
            pictureBox2.Image = ýmageList1.Images[zar2];
            sayac++;
            if (sayac == 10)
            {
                timer1.Stop();
                sayac = 0;
                TextZar1.Text = (zar1 + 1).ToString();
                TextZar2.Text = (zar2 + 1).ToString();
                buttonSkor.Enabled = true;
            }
        }

        private void buttonSkor_Click(object sender, EventArgs e)
        {
            buttonSkor.Enabled = false;
            buttonZar.Enabled = true;
            if (radioButton1.Checked == true)
            {
                listBox1.Items.Add(TextZar1.Text + " - " + TextZar2.Text);
                total1.Text = (Convert.ToInt32(total1.Text) + Convert.ToInt16(TextZar1.Text) + Convert.ToInt16(TextZar2.Text)).ToString();
            }
            if (radioButton2.Checked == true)
            {
                listBox2.Items.Add(TextZar1.Text + " - " + TextZar2.Text);
                total2.Text = (Convert.ToInt32(total2.Text) + Convert.ToInt16(TextZar1.Text) + Convert.ToInt16(TextZar2.Text)).ToString();
            }
        }

        private void buttonBasla_Click(object sender, EventArgs e)
        {
            buttonZar.Enabled = true;
            buttonBasla.Enabled = false;
            buttonBitir.Enabled = true;
        }

        private void buttonBitir_Click(object sender, EventArgs e)
        {
            int skor1 = Convert.ToInt32(total1.Text);
            int skor2 = Convert.ToInt32(total2.Text);
            if (skor1 > skor2)
            {
                MessageBox.Show("1. Oyuncu Kazandý!", "Oyun Bitti");
            }
            if (skor2 > skor1)
            {
                MessageBox.Show("2. Oyuncu Kazandý!", "Oyun Bitti");
            }
        }
    }
}