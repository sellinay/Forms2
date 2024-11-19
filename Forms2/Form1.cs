namespace Forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // OnlyAllowNumbers metodunu TextBox'lara baðlayýn
            txtYazili1.KeyPress += OnlyAllowNumbers;
            txtYazili2.KeyPress += OnlyAllowNumbers;
            txtPerformans1.KeyPress += OnlyAllowNumbers;
            txtPerformans2.KeyPress += OnlyAllowNumbers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanýcýdan alýnan notlarý al ve sayýya çevir
                double yazýlý1 = Convert.ToDouble(textBox1.Text);
                double yazýlý2 = Convert.ToDouble(textBox2.Text);
                double performans1 = Convert.ToDouble(textBox3.Text);
                double performans2 = Convert.ToDouble(textBox4.Text);

                // Ortalama hesapla
                double ortalama = (yazýlý1 + yazýlý2 + performans1 + performans2) / 4;

                // Ortalama sonucu Label'da göster
                lblOrtalama.Text = "Ortalama: " + ortalama.ToString("0.00");

                // Geçme durumunu kontrol et
                if (ortalama >= 50)
                {
                    lblDurum.Text = "GEÇTÝNÝZ";
                    lblDurum.ForeColor = Color.Green; // Rengi yeþil yap
                }
                else
                {
                    lblDurum.Text = "KALDINIZ";
                    lblDurum.ForeColor = Color.Red; // Rengi kýrmýzý yap
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanýcýya mesaj göster
                MessageBox.Show("Lütfen tüm alanlara geçerli bir sayý giriniz!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Sadece rakam giriþine izin veren metot (buraya ekliyoruz)
        private void OnlyAllowNumbers(object sender, KeyPressEventArgs e)
        {

            // Rakam, virgül ve geri silme tuþuna izin ver
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Geçersiz karakterleri engelle
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

