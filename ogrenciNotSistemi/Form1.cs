using ogrenciNotSistemi.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciNotSistemi
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\OgrenciNotSistemiDB.mdb";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama, öğrencilerin notlarını görüntülemesi, öğretmenlerin sisteme not girmesi ve yöneticilerin her iki tarafı da kontrol edebildiği bir Öğrenci Not Sistemi uygulamasıdır.", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.linkedin.com/in/asya-naz-uğurlu-7ab15032a");
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string rol = "";

            if (kullaniciAdi != "" && sifre != "")
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "select * from Ogrenciler where Numara=@numara and Sifre=@sifre";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@numara", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                rol = "Öğrenci";
                                string ogrenciAd = reader["Ad"].ToString();
                                string ogrenciSoyad = reader["Soyad"].ToString();
                                string adSoyad = ogrenciAd + " " + ogrenciSoyad;
                                OgrenciForm ogr = new OgrenciForm(adSoyad);
                                ogr.ogrenciNo = Convert.ToInt32(kullaniciAdi);
                                this.Hide();
                                ogr.ShowDialog();
                            }
                        }
                    }
                    if (rol == "")
                    {
                        string query2 = "select * from Ogretmenler where KullaniciAdi=@kullaniciAdi and Sifre=@sifre";

                        using (OleDbCommand cmd = new OleDbCommand(query2, conn))
                        {
                            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                            cmd.Parameters.AddWithValue("@sifre", sifre);

                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    rol = "Öğretmen";
                                    string ogretmenAd = reader["Ad"].ToString(); 
                                    string ogretmenSoyad = reader["Soyad"].ToString();
                                    string adSoyad = ogretmenAd + " " + ogretmenSoyad;
                                    OgretmenForm ogr = new OgretmenForm(adSoyad);
                                    this.Hide();
                                    ogr.ShowDialog();
                                }
                            }
                        }
                    }
                }
                if (rol == "")
                {
                    MessageBox.Show("Kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz!", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtKullaniciAdi;
        }
    }
}
