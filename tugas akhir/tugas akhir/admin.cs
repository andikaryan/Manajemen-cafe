using System;
using System.Data;
using System.Net;
using System.Windows.Forms;
using Npgsql;

namespace tugas_akhir
{
    public partial class admin : Form
    {

        private string id = "";
        private int intRow = 0;

        public admin()
        {
            InitializeComponent();
            resetMe();
        }

        private void resetMe()
        {
            this.id = string.Empty;

            namaMenuTextBox.Text = "";
            HargatextBox.Text = "";

            if (KategoricomboBox.Items.Count > 0)
            {
                KategoricomboBox.SelectedIndex = 0;
            }

            TombolUpdate.Text = "Update";
            TombolDelete.Text = "Delete";

            CaritextBox.Clear();

            if (CaritextBox.CanSelect)
            {
                CaritextBox.Select();
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void LoadData(string keyword)
        {
            CRUD.sql = "SELECT id, nama, harga, kategori FROM menu WHERE CAST(id as varchar) LIKE @keyword::varchar OR (nama) LIKE @keyword::varchar OR (kategori) LIKE @keyword::varchar ORDER BY id ASC";

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

            toolStripStatusLabel1.Text = "Jumlah Menu " + intRow.ToString();

            DataGridView dgv1 = dataGridView1;

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.DataSource = dt;

            dgv1.Columns[0].HeaderText = "ID";
            dgv1.Columns[1].HeaderText = "Nama";
            dgv1.Columns[2].HeaderText = "Harga";
            dgv1.Columns[3].HeaderText = "Kategori";

            dgv1.Columns[0].Width = 85;
            dgv1.Columns[1].Width = 200;
            dgv1.Columns[2].Width = 170;
            dgv1.Columns[3].Width = 200;

        }

        private void execute(string MySQL, string param)
        {
            CRUD.cmd = new NpgsqlCommand(MySQL, CRUD.con);
            addParameters(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        private void addParameters(string str)
        {
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("nama", namaMenuTextBox.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("harga", Convert.ToInt32(HargatextBox.Text.Trim()));
            CRUD.cmd.Parameters.AddWithValue("kategori", KategoricomboBox.SelectedItem.ToString());

            if (str == "Update" || str == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }
        }

        private void TombolInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namaMenuTextBox.Text.Trim()) || string.IsNullOrEmpty(HargatextBox.Text.Trim()))
            {
                MessageBox.Show("Masukkan nama menu dan harga");
                return;
            }

            CRUD.sql = "INSERT INTO menu(nama, harga, kategori) VALUES (@nama, @harga, @kategori)";

            execute(CRUD.sql, "Insert");

            MessageBox.Show("Berhasil Disimpan");

            LoadData("");

            resetMe();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = dataGridView1;

                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                TombolUpdate.Text = "Update(" + this.id + ")";
                TombolDelete.Text = "Delete(" + this.id + ")";

                namaMenuTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                HargatextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);

                KategoricomboBox.SelectedItem = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);
            }
        }


        private void TombolUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Pilih menu yang ingin di update");
                return;
            }

            if (string.IsNullOrEmpty(namaMenuTextBox.Text.Trim()) || string.IsNullOrEmpty(HargatextBox.Text.Trim()))
            {
                MessageBox.Show("Masukkan nama menu dan harga");
                return;
            }

            CRUD.sql = "UPDATE menu SET nama = @nama, harga = @harga, kategori = @kategori WHERE id = @id::integer";

            execute(CRUD.sql, "Update");

            MessageBox.Show("Berhasil Diupdate");

            LoadData("");

            resetMe();
        }

        private void TombolDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Pilih menu yang ingin di hapus");
                return;
            }

            if (string.IsNullOrEmpty(namaMenuTextBox.Text.Trim()) || string.IsNullOrEmpty(HargatextBox.Text.Trim()))
            {
                MessageBox.Show("Masukkan nama menu dan harga");
                return;
            }

            CRUD.sql = "DELETE FROM menu WHERE id = @id::integer";

            execute(CRUD.sql, "Delete");

            MessageBox.Show("Berhasil Dihapus");

            LoadData("");

            resetMe();

        }

        private void tombolCari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CaritextBox.Text.Trim()))
            {
                LoadData("");
            }
            else
            {
                LoadData(CaritextBox.Text.Trim());
            }

            resetMe();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
