using System.Globalization;

namespace FormControll
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //1. mengecek apakah username dan password sudah sesuai? username="admin" password="1234"
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "1234")
            {
                //2. Jika sesuai, tampilkan pesan "login sukses" 
                MessageBox.Show("Login Sukses");
                //3. Beralih ke form pendaftaran kursus
                RegisForm frmRegis = new RegisForm();
                this.Hide();
                frmRegis.Show();
            }
            else
            {
                // jika tidak cocok, tampilkan pesan login gagal dan reset form
                MessageBox.Show("Login Gagal");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
        }
    }
}
