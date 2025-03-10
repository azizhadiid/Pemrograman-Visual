namespace PojectKalkulator
{
    public partial class FormKalkulator : Form
    {
        String strDisplay;
        Double temp;
        String operasi;

        public FormKalkulator()
        {
            InitializeComponent();
            strDisplay = "";
            temp = 0.0;
            operasi = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // menmpilkan angka 1 dilayar
            strDisplay += "1";
            textBox1.Text = strDisplay;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            strDisplay += "2";
            textBox1.Text = strDisplay;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            strDisplay += "3";
            textBox1.Text = strDisplay;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            strDisplay += "4";
            textBox1.Text = strDisplay;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            strDisplay += "5";
            textBox1.Text = strDisplay;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            strDisplay += "6";
            textBox1.Text = strDisplay;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            strDisplay += "7";
            textBox1.Text = strDisplay;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            strDisplay += "8";
            textBox1.Text = strDisplay;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            strDisplay += "9";
            textBox1.Text = strDisplay;
        }

        private void buttonNol_Click(object sender, EventArgs e)
        {
            strDisplay += "0";
            textBox1.Text = strDisplay;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // menyimpan nilai yang ada di layar ke variabel temp;
            temp = Convert.ToDouble(textBox1.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
            // menyimpan jenis operasi adalah penjumlahan;
            operasi = "+";
            // mereset display menjadi kosong;
            strDisplay = "";
        }

        private void buttonSamaDengan_Click(object sender, EventArgs e)
        {
            double hasil = 0.0;
            double angkaInput = Convert.ToDouble(textBox1.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);

            if (operasi == "+")
            {
                hasil = temp + angkaInput;
            }
            else if (operasi == "-")
            {
                hasil = temp - angkaInput;
            }
            else if (operasi == "x")
            {
                hasil = temp * angkaInput;
            }
            else if (operasi == "/")
            {
                hasil = temp / angkaInput;
            }

            // Mengubah hasil menjadi format sesuai sistem lokal (titik/koma)
            strDisplay = hasil.ToString(System.Globalization.CultureInfo.CurrentCulture);
            textBox1.Text = strDisplay;
        }

        private void buttonKurang_Click(object sender, EventArgs e)
        {
            // menyimpan nilai yang ada di layar ke variabel temp;
            temp = Convert.ToDouble(textBox1.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
            // menyimpan jenis operasi adalah pengurangan;
            operasi = "-";
            // mereset display menjadi kosong;
            strDisplay = "";
        }

        private void buttonKali_Click(object sender, EventArgs e)
        {
            // menyimpan nilai yang ada di layar ke variabel temp;
            temp = Convert.ToDouble(textBox1.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
            // menyimpan jenis operasi adalah pengalian;
            operasi = "x";
            // mereset display menjadi kosong;
            strDisplay = "";
        }

        private void buttonBagi_Click(object sender, EventArgs e)
        {
            // menyimpan nilai yang ada di layar ke variabel temp;
            temp = Convert.ToDouble(textBox1.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
            // menyimpan jenis operasi adalah pembagian;
            operasi = "/";
            // mereset display menjadi kosong;
            strDisplay = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (strDisplay.Length > 0)
            {
                // Hapus karakter terakhir dari strDisplay
                strDisplay = strDisplay.Substring(0, strDisplay.Length - 1);
                // Update textBox1
                textBox1.Text = strDisplay;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (strDisplay.Length > 0)
            {
                // Hapus semua karakter 
                textBox1.Text = "0";
                strDisplay = "";
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void buttonTitik_Click(object sender, EventArgs e)
        {
            string decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (!strDisplay.Contains(decimalSeparator))
            {
                strDisplay += decimalSeparator;
                textBox1.Text = strDisplay;
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            // Pastikan textBox1 tidak kosong atau hanya nol
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "0")
            {
                // Konversi angka ke double
                double angka = Convert.ToDouble(textBox1.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);

                // Balikkan tanda plus/minus
                angka *= -1;

                // Simpan kembali ke strDisplay dan tampilkan di textBox1
                strDisplay = angka.ToString(System.Globalization.CultureInfo.CurrentCulture);
                textBox1.Text = strDisplay;
            }
        }
    }
}
