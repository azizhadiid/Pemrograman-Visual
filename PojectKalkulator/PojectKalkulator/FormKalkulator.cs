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
            temp = Convert.ToDouble(textBox1.Text);
            // menyimpan jenis operasi adalah penjumlahan;
            operasi = "+";
            // mereset display menjadi kosong;
            strDisplay = "";
        }

        private void buttonSamaDengan_Click(object sender, EventArgs e)
        {
            double hasil = 0.0;
            if (operasi == "+")
            {
                hasil = temp + Convert.ToDouble(textBox1.Text);
                strDisplay = hasil.ToString();
                textBox1.Text = strDisplay;
            }
            else if (operasi == "-")
            {
                hasil = temp - Convert.ToDouble(textBox1.Text);
                strDisplay = hasil.ToString();
                textBox1.Text = strDisplay;
            }
        }

        private void buttonKurang_Click(object sender, EventArgs e)
        {
            // menyimpan nilai yang ada di layar ke variabel temp;
            temp = Convert.ToDouble(textBox1.Text);
            // menyimpan jenis operasi adalah pengurangan;
            operasi = "-";
            // mereset display menjadi kosong;
            strDisplay = "";
        }
    }
}
