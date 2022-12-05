using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_akhir
{
    public partial class LoginAdmin : Form
    {
        string username = "admin";
        string password = "12345";

        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text.ToUpper() == username.ToUpper() && tbPassword.Text == password)
            {
                admin admn = new admin();
                admn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah, silahkan coba lagi");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
