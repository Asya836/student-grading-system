namespace ogrenciNotSistemi.forms
{
    partial class OgretmenForm
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnNotGoruntuleme = new System.Windows.Forms.Button();
            this.btnOgrenciGoruntuleme = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlOgrenciGoruntuleme = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlNotGoruntuleme = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBiyo = new System.Windows.Forms.Label();
            this.lblKimya = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblFizik = new System.Windows.Forms.Label();
            this.lblTurkce = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRaporlar = new System.Windows.Forms.Panel();
            this.lblToplamOgretmen = new System.Windows.Forms.Label();
            this.lblToplamDers = new System.Windows.Forms.Label();
            this.lblToplamOgrenci = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlOgrenciGoruntuleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlNotGoruntuleme.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlRaporlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRaporlar);
            this.panel1.Controls.Add(this.btnNotGoruntuleme);
            this.panel1.Controls.Add(this.btnOgrenciGoruntuleme);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 591);
            this.panel1.TabIndex = 3;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnCikis.Location = new System.Drawing.Point(168, 531);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(147, 48);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "ÇIKIŞ YAP";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.label4.Location = new System.Drawing.Point(64, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "isim";
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnRaporlar.FlatAppearance.BorderSize = 0;
            this.btnRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporlar.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnRaporlar.Location = new System.Drawing.Point(9, 430);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(315, 48);
            this.btnRaporlar.TabIndex = 8;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnNotGoruntuleme
            // 
            this.btnNotGoruntuleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnNotGoruntuleme.FlatAppearance.BorderSize = 0;
            this.btnNotGoruntuleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotGoruntuleme.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotGoruntuleme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnNotGoruntuleme.Location = new System.Drawing.Point(9, 352);
            this.btnNotGoruntuleme.Name = "btnNotGoruntuleme";
            this.btnNotGoruntuleme.Size = new System.Drawing.Size(315, 48);
            this.btnNotGoruntuleme.TabIndex = 7;
            this.btnNotGoruntuleme.Text = "Not Görüntüleme";
            this.btnNotGoruntuleme.UseVisualStyleBackColor = false;
            this.btnNotGoruntuleme.Click += new System.EventHandler(this.btnNotGoruntuleme_Click);
            // 
            // btnOgrenciGoruntuleme
            // 
            this.btnOgrenciGoruntuleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnOgrenciGoruntuleme.FlatAppearance.BorderSize = 0;
            this.btnOgrenciGoruntuleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciGoruntuleme.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciGoruntuleme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnOgrenciGoruntuleme.Location = new System.Drawing.Point(12, 274);
            this.btnOgrenciGoruntuleme.Name = "btnOgrenciGoruntuleme";
            this.btnOgrenciGoruntuleme.Size = new System.Drawing.Size(312, 48);
            this.btnOgrenciGoruntuleme.TabIndex = 6;
            this.btnOgrenciGoruntuleme.Text = "Öğrencileri Görüntüle";
            this.btnOgrenciGoruntuleme.UseVisualStyleBackColor = false;
            this.btnOgrenciGoruntuleme.Click += new System.EventHandler(this.btnOgrenciGoruntuleme_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ogrenciNotSistemi.Properties.Resources.icons8_teacher_50;
            this.pictureBox1.Location = new System.Drawing.Point(97, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(209)))));
            this.lblBilgi.Location = new System.Drawing.Point(333, 56);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(225, 31);
            this.lblBilgi.TabIndex = 1;
            this.lblBilgi.Text = "Öğretmen Paneli";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ogrenciNotSistemi.Properties.Resources.icons8_exit_24;
            this.pictureBox4.Location = new System.Drawing.Point(952, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pnlOgrenciGoruntuleme
            // 
            this.pnlOgrenciGoruntuleme.Controls.Add(this.dataGridView1);
            this.pnlOgrenciGoruntuleme.Location = new System.Drawing.Point(339, 90);
            this.pnlOgrenciGoruntuleme.Name = "pnlOgrenciGoruntuleme";
            this.pnlOgrenciGoruntuleme.Size = new System.Drawing.Size(649, 492);
            this.pnlOgrenciGoruntuleme.TabIndex = 4;
            this.pnlOgrenciGoruntuleme.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(649, 492);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnlNotGoruntuleme
            // 
            this.pnlNotGoruntuleme.Controls.Add(this.groupBox2);
            this.pnlNotGoruntuleme.Controls.Add(this.groupBox1);
            this.pnlNotGoruntuleme.Controls.Add(this.comboBox1);
            this.pnlNotGoruntuleme.Controls.Add(this.label1);
            this.pnlNotGoruntuleme.Location = new System.Drawing.Point(342, 87);
            this.pnlNotGoruntuleme.Name = "pnlNotGoruntuleme";
            this.pnlNotGoruntuleme.Size = new System.Drawing.Size(646, 492);
            this.pnlNotGoruntuleme.TabIndex = 6;
            this.pnlNotGoruntuleme.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBiyo);
            this.groupBox2.Controls.Add(this.lblKimya);
            this.groupBox2.Controls.Add(this.lblMat);
            this.groupBox2.Controls.Add(this.lblFizik);
            this.groupBox2.Controls.Add(this.lblTurkce);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(209)))));
            this.groupBox2.Location = new System.Drawing.Point(337, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 207);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Not Bilgileri";
            // 
            // lblBiyo
            // 
            this.lblBiyo.AutoSize = true;
            this.lblBiyo.Location = new System.Drawing.Point(15, 161);
            this.lblBiyo.Name = "lblBiyo";
            this.lblBiyo.Size = new System.Drawing.Size(68, 20);
            this.lblBiyo.TabIndex = 4;
            this.lblBiyo.Text = "Biyoloji:";
            // 
            // lblKimya
            // 
            this.lblKimya.AutoSize = true;
            this.lblKimya.Location = new System.Drawing.Point(15, 129);
            this.lblKimya.Name = "lblKimya";
            this.lblKimya.Size = new System.Drawing.Size(60, 20);
            this.lblKimya.TabIndex = 3;
            this.lblKimya.Text = "Kimya:";
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Location = new System.Drawing.Point(15, 65);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(91, 20);
            this.lblMat.TabIndex = 2;
            this.lblMat.Text = "Matematik:";
            // 
            // lblFizik
            // 
            this.lblFizik.AutoSize = true;
            this.lblFizik.Location = new System.Drawing.Point(15, 97);
            this.lblFizik.Name = "lblFizik";
            this.lblFizik.Size = new System.Drawing.Size(49, 20);
            this.lblFizik.TabIndex = 1;
            this.lblFizik.Text = "Fizik:";
            // 
            // lblTurkce
            // 
            this.lblTurkce.AutoSize = true;
            this.lblTurkce.Location = new System.Drawing.Point(15, 33);
            this.lblTurkce.Name = "lblTurkce";
            this.lblTurkce.Size = new System.Drawing.Size(65, 20);
            this.lblTurkce.TabIndex = 0;
            this.lblTurkce.Text = "Türkçe:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSifre);
            this.groupBox1.Controls.Add(this.lblNumara);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(209)))));
            this.groupBox1.Location = new System.Drawing.Point(24, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 207);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Kişisel Bilgileri";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(15, 161);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(62, 20);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifresi:";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(15, 129);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(86, 20);
            this.lblNumara.TabIndex = 3;
            this.lblNumara.Text = "Numarası:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(15, 65);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(38, 20);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Adı:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(15, 97);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(64, 20);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyadı:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 33);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(521, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(19, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci:";
            // 
            // pnlRaporlar
            // 
            this.pnlRaporlar.Controls.Add(this.lblToplamOgretmen);
            this.pnlRaporlar.Controls.Add(this.lblToplamDers);
            this.pnlRaporlar.Controls.Add(this.lblToplamOgrenci);
            this.pnlRaporlar.Controls.Add(this.label11);
            this.pnlRaporlar.Controls.Add(this.label10);
            this.pnlRaporlar.Controls.Add(this.label8);
            this.pnlRaporlar.Location = new System.Drawing.Point(485, 49);
            this.pnlRaporlar.Name = "pnlRaporlar";
            this.pnlRaporlar.Size = new System.Drawing.Size(458, 351);
            this.pnlRaporlar.TabIndex = 10;
            this.pnlRaporlar.Visible = false;
            // 
            // lblToplamOgretmen
            // 
            this.lblToplamOgretmen.AutoSize = true;
            this.lblToplamOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamOgretmen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(209)))));
            this.lblToplamOgretmen.Location = new System.Drawing.Point(300, 250);
            this.lblToplamOgretmen.Name = "lblToplamOgretmen";
            this.lblToplamOgretmen.Size = new System.Drawing.Size(26, 29);
            this.lblToplamOgretmen.TabIndex = 37;
            this.lblToplamOgretmen.Text = "0";
            // 
            // lblToplamDers
            // 
            this.lblToplamDers.AutoSize = true;
            this.lblToplamDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamDers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(209)))));
            this.lblToplamDers.Location = new System.Drawing.Point(300, 304);
            this.lblToplamDers.Name = "lblToplamDers";
            this.lblToplamDers.Size = new System.Drawing.Size(26, 29);
            this.lblToplamDers.TabIndex = 36;
            this.lblToplamDers.Text = "0";
            // 
            // lblToplamOgrenci
            // 
            this.lblToplamOgrenci.AutoSize = true;
            this.lblToplamOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamOgrenci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(209)))));
            this.lblToplamOgrenci.Location = new System.Drawing.Point(300, 196);
            this.lblToplamOgrenci.Name = "lblToplamOgrenci";
            this.lblToplamOgrenci.Size = new System.Drawing.Size(26, 29);
            this.lblToplamOgrenci.TabIndex = 35;
            this.lblToplamOgrenci.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(209)))));
            this.label11.Location = new System.Drawing.Point(7, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(285, 29);
            this.label11.TabIndex = 33;
            this.label11.Text = "Toplam öğretmen sayısı=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(209)))));
            this.label10.Location = new System.Drawing.Point(62, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 29);
            this.label10.TabIndex = 32;
            this.label10.Text = "Toplam ders sayısı=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(209)))));
            this.label8.Location = new System.Drawing.Point(29, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 29);
            this.label8.TabIndex = 30;
            this.label8.Text = "Toplam öğrenci sayısı=";
            // 
            // OgretmenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1000, 591);
            this.Controls.Add(this.pnlRaporlar);
            this.Controls.Add(this.pnlNotGoruntuleme);
            this.Controls.Add(this.pnlOgrenciGoruntuleme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblBilgi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgretmenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgretmenForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OgretmenForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlOgrenciGoruntuleme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlNotGoruntuleme.ResumeLayout(false);
            this.pnlNotGoruntuleme.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlRaporlar.ResumeLayout(false);
            this.pnlRaporlar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnNotGoruntuleme;
        private System.Windows.Forms.Button btnOgrenciGoruntuleme;
        private System.Windows.Forms.Panel pnlOgrenciGoruntuleme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlNotGoruntuleme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBiyo;
        private System.Windows.Forms.Label lblKimya;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label lblFizik;
        private System.Windows.Forms.Label lblTurkce;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRaporlar;
        private System.Windows.Forms.Label lblToplamOgretmen;
        private System.Windows.Forms.Label lblToplamDers;
        private System.Windows.Forms.Label lblToplamOgrenci;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCikis;
    }
}