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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TandaMenu = new System.Windows.Forms.Panel();
            this.menuCamilan = new System.Windows.Forms.Button();
            this.menuMinuman = new System.Windows.Forms.Button();
            this.menuMakanan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.food1 = new tugas_akhir.food();
            this.drink1 = new tugas_akhir.drink();
            this.snack1 = new tugas_akhir.snack();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
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
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(187, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 116);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(96, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Masukkan nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(752, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHOSE YOUR MENU HERE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // food1
            // 
            this.food1.AutoScroll = true;
            this.food1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.food1.Location = new System.Drawing.Point(206, 142);
            this.food1.Name = "food1";
            this.food1.Size = new System.Drawing.Size(658, 507);
            this.food1.TabIndex = 2;
            // 
            // drink1
            // 
            this.drink1.AutoScroll = true;
            this.drink1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.drink1.Location = new System.Drawing.Point(206, 142);
            this.drink1.Name = "drink1";
            this.drink1.Size = new System.Drawing.Size(658, 507);
            this.drink1.TabIndex = 3;
            // 
            // snack1
            // 
            this.snack1.AutoScroll = true;
            this.snack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.snack1.Location = new System.Drawing.Point(206, 142);
            this.snack1.Name = "snack1";
            this.snack1.Size = new System.Drawing.Size(658, 507);
            this.snack1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(895, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 507);
            this.panel3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.button1.Location = new System.Drawing.Point(187, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hapus Semua";
            this.button1.UseVisualStyleBackColor = false;
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
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(14, 394);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 97);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(234, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "00.00";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.button2.Location = new System.Drawing.Point(15, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pesan";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.snack1);
            this.Controls.Add(this.drink1);
            this.Controls.Add(this.food1);
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private TextBox textBox1;
        private food food1;
        private drink drink1;
        private snack snack1;
        private Panel panel3;
        private Button button1;
        private Label label3;
        private Panel panel4;
        private Button button2;
        private Label label5;
        private Label label4;
    }
}