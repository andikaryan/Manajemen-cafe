namespace tugas_akhir
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.CaritextBox = new System.Windows.Forms.TextBox();
            this.tombolCari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NamaMenu = new System.Windows.Forms.Label();
            this.Harga = new System.Windows.Forms.Label();
            this.Kategori = new System.Windows.Forms.Label();
            this.namaMenuTextBox = new System.Windows.Forms.TextBox();
            this.HargatextBox = new System.Windows.Forms.TextBox();
            this.KategoricomboBox = new System.Windows.Forms.ComboBox();
            this.TombolInsert = new System.Windows.Forms.Button();
            this.TombolUpdate = new System.Windows.Forms.Button();
            this.TombolDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.btLogout);
            this.panel1.Controls.Add(this.CaritextBox);
            this.panel1.Controls.Add(this.tombolCari);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 76);
            this.panel1.TabIndex = 0;
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(59, 21);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(94, 29);
            this.btLogout.TabIndex = 12;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // CaritextBox
            // 
            this.CaritextBox.Location = new System.Drawing.Point(453, 23);
            this.CaritextBox.Name = "CaritextBox";
            this.CaritextBox.Size = new System.Drawing.Size(231, 27);
            this.CaritextBox.TabIndex = 2;
            // 
            // tombolCari
            // 
            this.tombolCari.Location = new System.Drawing.Point(713, 23);
            this.tombolCari.Name = "tombolCari";
            this.tombolCari.Size = new System.Drawing.Size(94, 29);
            this.tombolCari.TabIndex = 1;
            this.tombolCari.Text = "Cari";
            this.tombolCari.UseVisualStyleBackColor = true;
            this.tombolCari.Click += new System.EventHandler(this.tombolCari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(256, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "J-CAFE";
            // 
            // NamaMenu
            // 
            this.NamaMenu.AutoSize = true;
            this.NamaMenu.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NamaMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.NamaMenu.Location = new System.Drawing.Point(59, 134);
            this.NamaMenu.Name = "NamaMenu";
            this.NamaMenu.Size = new System.Drawing.Size(107, 21);
            this.NamaMenu.TabIndex = 1;
            this.NamaMenu.Text = "Nama Menu";
            this.NamaMenu.Click += new System.EventHandler(this.label2_Click);
            // 
            // Harga
            // 
            this.Harga.AutoSize = true;
            this.Harga.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Harga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Harga.Location = new System.Drawing.Point(59, 181);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(59, 21);
            this.Harga.TabIndex = 2;
            this.Harga.Text = "Harga";
            // 
            // Kategori
            // 
            this.Kategori.AutoSize = true;
            this.Kategori.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Kategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Kategori.Location = new System.Drawing.Point(59, 228);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(79, 21);
            this.Kategori.TabIndex = 3;
            this.Kategori.Text = "Kategori";
            // 
            // namaMenuTextBox
            // 
            this.namaMenuTextBox.Location = new System.Drawing.Point(207, 132);
            this.namaMenuTextBox.Name = "namaMenuTextBox";
            this.namaMenuTextBox.Size = new System.Drawing.Size(151, 27);
            this.namaMenuTextBox.TabIndex = 4;
            // 
            // HargatextBox
            // 
            this.HargatextBox.Location = new System.Drawing.Point(207, 181);
            this.HargatextBox.Name = "HargatextBox";
            this.HargatextBox.Size = new System.Drawing.Size(151, 27);
            this.HargatextBox.TabIndex = 5;
            // 
            // KategoricomboBox
            // 
            this.KategoricomboBox.FormattingEnabled = true;
            this.KategoricomboBox.Items.AddRange(new object[] {
            "Makanan",
            "Minuman",
            "Camilan"});
            this.KategoricomboBox.Location = new System.Drawing.Point(207, 228);
            this.KategoricomboBox.Name = "KategoricomboBox";
            this.KategoricomboBox.Size = new System.Drawing.Size(151, 28);
            this.KategoricomboBox.TabIndex = 6;
            // 
            // TombolInsert
            // 
            this.TombolInsert.Location = new System.Drawing.Point(453, 156);
            this.TombolInsert.Name = "TombolInsert";
            this.TombolInsert.Size = new System.Drawing.Size(94, 72);
            this.TombolInsert.TabIndex = 7;
            this.TombolInsert.Text = "Insert";
            this.TombolInsert.UseVisualStyleBackColor = true;
            this.TombolInsert.Click += new System.EventHandler(this.TombolInsert_Click);
            // 
            // TombolUpdate
            // 
            this.TombolUpdate.Location = new System.Drawing.Point(580, 156);
            this.TombolUpdate.Name = "TombolUpdate";
            this.TombolUpdate.Size = new System.Drawing.Size(94, 72);
            this.TombolUpdate.TabIndex = 8;
            this.TombolUpdate.Text = "Update";
            this.TombolUpdate.UseVisualStyleBackColor = true;
            this.TombolUpdate.Click += new System.EventHandler(this.TombolUpdate_Click);
            // 
            // TombolDelete
            // 
            this.TombolDelete.Location = new System.Drawing.Point(713, 156);
            this.TombolDelete.Name = "TombolDelete";
            this.TombolDelete.Size = new System.Drawing.Size(94, 72);
            this.TombolDelete.TabIndex = 9;
            this.TombolDelete.Text = "Delete";
            this.TombolDelete.UseVisualStyleBackColor = true;
            this.TombolDelete.Click += new System.EventHandler(this.TombolDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(748, 333);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 647);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(111, 20);
            this.toolStripStatusLabel1.Text = "Jumlah Menu ";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(870, 673);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TombolDelete);
            this.Controls.Add(this.TombolUpdate);
            this.Controls.Add(this.TombolInsert);
            this.Controls.Add(this.KategoricomboBox);
            this.Controls.Add(this.HargatextBox);
            this.Controls.Add(this.namaMenuTextBox);
            this.Controls.Add(this.Kategori);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.NamaMenu);
            this.Controls.Add(this.panel1);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label NamaMenu;
        private Label Harga;
        private Label Kategori;
        private TextBox namaMenuTextBox;
        private TextBox HargatextBox;
        private ComboBox KategoricomboBox;
        private Button TombolInsert;
        private Button TombolUpdate;
        private Button TombolDelete;
        private DataGridView dataGridView1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox CaritextBox;
        private Button tombolCari;
        private Button btLogout;
    }
}