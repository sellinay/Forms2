namespace Forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // OnlyAllowNumbers metodunu TextBox'lara ba�lay�n
            txtYazili1.KeyPress += OnlyAllowNumbers;
            txtYazili2.KeyPress += OnlyAllowNumbers;
            txtPerformans1.KeyPress += OnlyAllowNumbers;
            txtPerformans2.KeyPress += OnlyAllowNumbers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullan�c�dan al�nan notlar� al ve say�ya �evir
                double yaz�l�1 = Convert.ToDouble(textBox1.Text);
                double yaz�l�2 = Convert.ToDouble(textBox2.Text);
                double performans1 = Convert.ToDouble(textBox3.Text);
                double performans2 = Convert.ToDouble(textBox4.Text);

                // Ortalama hesapla
                double ortalama = (yaz�l�1 + yaz�l�2 + performans1 + performans2) / 4;

                // Ortalama sonucu Label'da g�ster
                lblOrtalama.Text = "Ortalama: " + ortalama.ToString("0.00");

                // Ge�me durumunu kontrol et
                if (ortalama >= 50)
                {
                    lblDurum.Text = "GE�T�N�Z";
                    lblDurum.ForeColor = Color.Green; // Rengi ye�il yap
                }
                else
                {
                    lblDurum.Text = "KALDINIZ";
                    lblDurum.ForeColor = Color.Red; // Rengi k�rm�z� yap
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullan�c�ya mesaj g�ster
                MessageBox.Show("L�tfen t�m alanlara ge�erli bir say� giriniz!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Sadece rakam giri�ine izin veren metot (buraya ekliyoruz)
        private void OnlyAllowNumbers(object sender, KeyPressEventArgs e)
        {

            // Rakam, virg�l ve geri silme tu�una izin ver
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ge�ersiz karakterleri engelle
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOrtalama_Click(object sender, EventArgs e)
        {

        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

