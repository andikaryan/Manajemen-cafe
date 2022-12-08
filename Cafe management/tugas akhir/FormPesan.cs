using Npgsql;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace tugas_akhir
{
    public partial class FormPesan : Form
    {

        private int intRow = 0;
        public FormPesan()
        {
            InitializeComponent();
            TandaMenu.Height = menuMakanan.Height;
            TandaMenu.Top = menuMakanan.Top;

        }

        DataTable table = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            makanan("");
            table.Columns.Add("Nama menu", typeof(string));
            table.Columns.Add("Jumlah", typeof(int));
            table.Columns.Add("Harga", typeof(int));
            gvPesanan.DataSource = table;
            gvPesanan.Columns[0].Width = 150;
            gvPesanan.Columns[1].Width = 107;
            gvPesanan.Columns[2].Width = 130;


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

        private void menuCamilan_Click(object sender, EventArgs e)
        {
            TandaMenu.Height = menuCamilan.Height;
            TandaMenu.Top = menuCamilan.Top;
            camilan("");
        }

        private void Keluar_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }


        int Harga;
        int Jumlah;
        string Nama;
        int Total = 0;
        int sum = 0;
        private void listMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Nama = listMenu.SelectedRows[0].Cells[0].Value.ToString();
            Harga = Convert.ToInt32(listMenu.SelectedRows[0].Cells[1].Value.ToString());

        }

        private void TambahPesanan_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbJumlah.Text.Trim()))
            {
                MessageBox.Show("Masukkan jumlah menu");
            }
            else if (Nama == null)
            {
                MessageBox.Show("Pilih menu yang ingin dipesan");
            }
            else
            {

                Jumlah = Convert.ToInt32(tbJumlah.Text);
                Total = Jumlah * Harga;
                table.Rows.Add(Nama,Jumlah,Total);
                gvPesanan.DataSource = table;

                sum = sum + Total;
                textTotal.Text = "Rp" + sum;
            }
            
        }

        int amount;

        private void gvPesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = Convert.ToInt32(gvPesanan.SelectedRows[0].Cells[2].Value.ToString());
                //amount = int.Parse(gvPesanan.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            catch { }
        }


        private void hapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvPesanan.Rows.Count == 0)
                {
                    MessageBox.Show("Mohon isi pesanan dulu");
                }
                else if (amount == null)
                {
                    MessageBox.Show("pilih pesanan");
                }
                else
                {
                    gvPesanan.Rows.RemoveAt(gvPesanan.SelectedRows[0].Index);
                    sum -= amount;
                    if (sum < 0)
                    {
                        sum = 0;
                    }
                    textTotal.Text = "Rp " + sum;
                }
            }
            catch { }


        }


        //Bitmap bmp;

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "NOTA PEMBELIAN";
            printer.SubTitle = String.Format("Tanggal : {0}", DateTime.Now);
            //printer.SubTitle = String.Format("Total : " + textTotal.Text);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true; // if you need page numbers you can keep this as true other wise false
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "TOTAL : "+ textTotal.Text + Environment.NewLine +"Nama Pelanggan : " + tbNama.Text ; 
            printer.FooterSpacing = 50;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(gvPesanan);
            
            //printer.("Total harga : " + textTotal);

        }
    }
}