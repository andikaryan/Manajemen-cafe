namespace tugas_akhir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TandaMenu.Height = menuMakanan.Height;
            TandaMenu.Top = menuMakanan.Top;
            food1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

        private void menuMakanan_Click(object sender, EventArgs e)
        {
            TandaMenu.Height = menuMakanan.Height;
            TandaMenu.Top = menuMakanan.Top;
            food1.BringToFront();
        }

        private void menuMinuman_Click(object sender, EventArgs e)
        {
            TandaMenu.Height = menuMinuman.Height;
            TandaMenu.Top = menuMinuman.Top;
            drink1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TandaMenu.Height = menuCamilan.Height;
            TandaMenu.Top = menuCamilan.Top;
            snack1.BringToFront();
        }
    }
}