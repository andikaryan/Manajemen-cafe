using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace tugas_akhir
{
    public partial class Form1 : Form
    {
        private string id = "";
        private int intRow = 0;
        public Form1()
        {
            InitializeComponent();
            TandaMenu.Height = menuMakanan.Height;
            TandaMenu.Top = menuMakanan.Top;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            makanan("");
        }

        private void LoadData(string keyword)
        {
            CRUD.sql = "SELECT nama, harga FROM menu ORDER BY id ASC";

            string strKeyword = string.Format("%{0}%", keyword);

            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("Keyword", strKeyword);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                intRow = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                intRow = 0;
            }


            DataGridView dgv1 = listMenu;

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.DataSource = dt;


            dgv1.Columns[0].HeaderText = "Nama";
            dgv1.Columns[1].HeaderText = "Harga";



            dgv1.Columns[0].Width = 270;
            dgv1.Columns[1].Width = 269;


        }

        private void execute(string MySQL, string param)
        {
            CRUD.cmd = new NpgsqlCommand(MySQL, CRUD.con);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void food2_Load(object sender, EventArgs e)
        {

        }

        private void food1_Load(object sender, EventArgs e)
        {

        }

        private void food2_Load_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void food1_Load_1(object sender, EventArgs e)
        {

        }

        private void food1_Load_2(object sender, EventArgs e)
        {

        }

        private void makanan(string keyword)
        {
            CRUD.sql = "SELECT nama, harga FROM menu WHERE kategori = 'Makanan' ORDER BY id ASC";

            string strKeyword = string.Format("%{0}%", keyword);

            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("Keyword", strKeyword);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                intRow = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                intRow = 0;
            }


            DataGridView dgv1 = listMenu;

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.DataSource = dt;


            dgv1.Columns[0].HeaderText = "Nama";
            dgv1.Columns[1].HeaderText = "Harga";



            dgv1.Columns[0].Width = 270;
            dgv1.Columns[1].Width = 269;


        }

        private void menuMakanan_Click(object sender, EventArgs e)
        {
            TandaMenu.Height = menuMakanan.Height;
            TandaMenu.Top = menuMakanan.Top;
            makanan("");
        }

        private void minuman(string keyword)
        {
            CRUD.sql = "SELECT nama, harga FROM menu WHERE kategori = 'Minuman' ORDER BY id ASC";

            string strKeyword = string.Format("%{0}%", keyword);

            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("Keyword", strKeyword);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                intRow = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                intRow = 0;
            }


            DataGridView dgv1 = listMenu;

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.DataSource = dt;


            dgv1.Columns[0].HeaderText = "Nama";
            dgv1.Columns[1].HeaderText = "Harga";



            dgv1.Columns[0].Width = 270;
            dgv1.Columns[1].Width = 269;


        }

        private void menuMinuman_Click(object sender, EventArgs e)
        {
            TandaMenu.Height = menuMinuman.Height;
            TandaMenu.Top = menuMinuman.Top;
            minuman("");
        }

        private void camilan(string keyword)
        {
            CRUD.sql = "SELECT nama, harga FROM menu WHERE kategori = 'Camilan' ORDER BY id ASC";

            string strKeyword = string.Format("%{0}%", keyword);

            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("Keyword", strKeyword);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                intRow = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                intRow = 0;
            }


            DataGridView dgv1 = listMenu;

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.DataSource = dt;


            dgv1.Columns[0].HeaderText = "Nama";
            dgv1.Columns[1].HeaderText = "Harga";



            dgv1.Columns[0].Width = 270;
            dgv1.Columns[1].Width = 269;


        }
        private void button3_Click(object sender, EventArgs e)
        {
            TandaMenu.Height = menuCamilan.Height;
            TandaMenu.Top = menuCamilan.Top;
            camilan("");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

    }
}