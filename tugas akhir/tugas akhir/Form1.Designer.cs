namespace tugas_akhir
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TandaMenu = new System.Windows.Forms.Panel();
            this.menuCamilan = new System.Windows.Forms.Button();
            this.menuMinuman = new System.Windows.Forms.Button();
            this.menuMakanan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gvPesanan = new System.Windows.Forms.DataGridView();
            this.namaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listMenu = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TambahPesanan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPesanan)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listMenu)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TandaMenu);
            this.panel1.Controls.Add(this.menuCamilan);
            this.panel1.Controls.Add(this.menuMinuman);
            this.panel1.Controls.Add(this.menuMakanan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 673);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.button3.Location = new System.Drawing.Point(34, 620);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Keluar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 104);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "J-CAFE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TandaMenu
            // 
            this.TandaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.TandaMenu.Location = new System.Drawing.Point(3, 190);
            this.TandaMenu.Name = "TandaMenu";
            this.TandaMenu.Size = new System.Drawing.Size(15, 64);
            this.TandaMenu.TabIndex = 2;
            // 
            // menuCamilan
            // 
            this.menuCamilan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuCamilan.FlatAppearance.BorderSize = 0;
            this.menuCamilan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuCamilan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuCamilan.Image = ((System.Drawing.Image)(resources.GetObject("menuCamilan.Image")));
            this.menuCamilan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuCamilan.Location = new System.Drawing.Point(24, 330);
            this.menuCamilan.Name = "menuCamilan";
            this.menuCamilan.Size = new System.Drawing.Size(163, 64);
            this.menuCamilan.TabIndex = 2;
            this.menuCamilan.Text = " Camilan";
            this.menuCamilan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuCamilan.UseVisualStyleBackColor = true;
            this.menuCamilan.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuMinuman
            // 
            this.menuMinuman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuMinuman.FlatAppearance.BorderSize = 0;
            this.menuMinuman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuMinuman.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuMinuman.Image = ((System.Drawing.Image)(resources.GetObject("menuMinuman.Image")));
            this.menuMinuman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuMinuman.Location = new System.Drawing.Point(24, 260);
            this.menuMinuman.Name = "menuMinuman";
            this.menuMinuman.Size = new System.Drawing.Size(163, 64);
            this.menuMinuman.TabIndex = 1;
            this.menuMinuman.Text = " Minuman";
            this.menuMinuman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuMinuman.UseVisualStyleBackColor = true;
            this.menuMinuman.Click += new System.EventHandler(this.menuMinuman_Click);
            // 
            // menuMakanan
            // 
            this.menuMakanan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuMakanan.FlatAppearance.BorderSize = 0;
            this.menuMakanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuMakanan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuMakanan.Image = ((System.Drawing.Image)(resources.GetObject("menuMakanan.Image")));
            this.menuMakanan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuMakanan.Location = new System.Drawing.Point(24, 190);
            this.menuMakanan.Name = "menuMakanan";
            this.menuMakanan.Size = new System.Drawing.Size(163, 64);
            this.menuMakanan.TabIndex = 0;
            this.menuMakanan.Text = " Makanan";
            this.menuMakanan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuMakanan.UseVisualStyleBackColor = true;
            this.menuMakanan.Click += new System.EventHandler(this.menuMakanan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(187, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 116);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(507, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILIH MENU ANDA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbJumlah
            // 
            this.tbJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbJumlah.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbJumlah.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbJumlah.Location = new System.Drawing.Point(164, 447);
            this.tbJumlah.Multiline = true;
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(184, 27);
            this.tbJumlah.TabIndex = 1;
            this.tbJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJumlah_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.gvPesanan);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(844, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 507);
            this.panel3.TabIndex = 5;
            // 
            // gvPesanan
            // 
            this.gvPesanan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.gvPesanan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPesanan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvPesanan.ColumnHeadersHeight = 32;
            this.gvPesanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaMenu,
            this.Jumlah,
            this.Harga});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPesanan.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvPesanan.EnableHeadersVisualStyles = false;
            this.gvPesanan.Location = new System.Drawing.Point(14, 63);
            this.gvPesanan.Name = "gvPesanan";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPesanan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvPesanan.RowHeadersVisible = false;
            this.gvPesanan.RowHeadersWidth = 51;
            this.gvPesanan.RowTemplate.Height = 29;
            this.gvPesanan.Size = new System.Drawing.Size(440, 309);
            this.gvPesanan.TabIndex = 12;
            this.gvPesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPesanan_CellContentClick);
            // 
            // namaMenu
            // 
            this.namaMenu.HeaderText = "Nama Menu";
            this.namaMenu.MinimumWidth = 6;
            this.namaMenu.Name = "namaMenu";
            this.namaMenu.Width = 162;
            // 
            // Jumlah
            // 
            this.Jumlah.HeaderText = "Jumlah";
            this.Jumlah.MinimumWidth = 6;
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Width = 135;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.MinimumWidth = 6;
            this.Harga.Name = "Harga";
            this.Harga.Width = 140;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.total);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(14, 394);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 97);
            this.panel4.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.button2.Location = new System.Drawing.Point(39, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(361, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pesan";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total.Location = new System.Drawing.Point(346, 20);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(54, 19);
            this.total.TabIndex = 3;
            this.total.Text = "00.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.button1.Location = new System.Drawing.Point(323, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hapus Semua";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Menu Dipilih :";
            // 
            // listMenu
            // 
            this.listMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.listMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listMenu.ColumnHeadersHeight = 32;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listMenu.DefaultCellStyle = dataGridViewCellStyle5;
            this.listMenu.EnableHeadersVisualStyles = false;
            this.listMenu.Location = new System.Drawing.Point(14, 46);
            this.listMenu.Name = "listMenu";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.listMenu.RowHeadersVisible = false;
            this.listMenu.RowHeadersWidth = 51;
            this.listMenu.RowTemplate.Height = 29;
            this.listMenu.Size = new System.Drawing.Size(542, 352);
            this.listMenu.TabIndex = 11;
            this.listMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listMenu_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel5.Controls.Add(this.tbJumlah);
            this.panel5.Controls.Add(this.TambahPesanan);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.listMenu);
            this.panel5.Location = new System.Drawing.Point(224, 142);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(569, 507);
            this.panel5.TabIndex = 12;
            // 
            // TambahPesanan
            // 
            this.TambahPesanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.TambahPesanan.FlatAppearance.BorderSize = 0;
            this.TambahPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TambahPesanan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TambahPesanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.TambahPesanan.Location = new System.Drawing.Point(369, 445);
            this.TambahPesanan.Name = "TambahPesanan";
            this.TambahPesanan.Size = new System.Drawing.Size(111, 29);
            this.TambahPesanan.TabIndex = 14;
            this.TambahPesanan.Text = "Tambah";
            this.TambahPesanan.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(75, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Jumlah :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Daftar Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1351, 673);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPesanan)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listMenu)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button menuMakanan;
        private Label label2;
        private Panel TandaMenu;
        private Button menuCamilan;
        private Button menuMinuman;
        private PictureBox pictureBox1;
        private TextBox tbJumlah;
        private Panel panel3;
        private Button button1;
        private Label label3;
        private Panel panel4;
        private Button button2;
        private Label total;
        private Label label4;
        private Button button3;
        private DataGridView listMenu;
        private Panel panel5;
        private Label label6;
        private Button TambahPesanan;
        private Label label7;
        private DataGridView gvPesanan;
        private DataGridViewTextBoxColumn namaMenu;
        private DataGridViewTextBoxColumn Jumlah;
        private DataGridViewTextBoxColumn Harga;
    }
}