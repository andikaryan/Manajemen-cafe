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
    public partial class LoginPelanggan : Form
    {
        public LoginPelanggan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPesan menuUtama = new FormPesan();
            menuUtama.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginAdmin LAdmin = new LoginAdmin();
            LAdmin.Show();
            this.Hide();
        }
    }
}
