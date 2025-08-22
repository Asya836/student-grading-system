using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciNotSistemi.forms
{
    public partial class OgretmenForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private int ogrenciId;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\OgrenciNotSistemiDB.mdb";

        private void GetStudents()
        {
            pnlNotGoruntuleme.Visible = false;
            pnlRaporlar.Visible = false;
            pnlOgrenciGoruntuleme.Visible = true;

            string query = "select ID,Ad,Soyad,Numara,Sifre from Ogrenciler";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    OleDbDataAdapter dtadapter = new OleDbDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    dtadapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    lblBilgi.Text = "Öğrenci Bilgileri";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public OgretmenForm(string adSoyad)
        {
            InitializeComponent();
            label4.Text = adSoyad;
            comboBox1.SelectedIndexChanged +=comboBox1_SelectedIndexChanged;
        }
        private void ListData()
        {
            if (comboBox1.SelectedItem != null)
            {
                DataRowView row = comboBox1.SelectedItem as DataRowView;

                if (row != null)
                {
                    ogrenciId = Convert.ToInt32(row["ID"]);
                    lblId.Text = "ID: " + row["ID"].ToString();
                    lblAd.Text = "Adı: " + row["Ad"].ToString();
                    lblSoyad.Text = "Soyadı: " + row["Soyad"].ToString();
                    lblNumara.Text = "Numarası: " + row["Numara"].ToString();
                    lblSifre.Text = "Şifresi: " + row["Sifre"].ToString();

                    lblTurkce.Text = "Türkçe: " + row["Turkce"].ToString();
                    lblMat.Text = "Matematik: " + row["Matematik"].ToString();
                    lblFizik.Text = "Fizik: " + row["Fizik"].ToString();
                    lblKimya.Text = "Kimya: " + row["Kimya"].ToString();
                    lblBiyo.Text = "Biyoloji: " + row["Biyoloji"].ToString();
                }
            }
            
        }

        private void NotGoruntule()
        {
            string query = "select * from Ogrenciler";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter dtadapter = new OleDbDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    dtadapter.Fill(dt);
                    comboBox1.DisplayMember = "Ad";
                    comboBox1.ValueMember = "ID";
                    comboBox1.DataSource = dt;
                }
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
                ListData();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnOgrenciGoruntuleme_Click(object sender, EventArgs e)
        {
            GetStudents();
        }

        private void btnNotGoruntuleme_Click(object sender, EventArgs e)
        {
            pnlNotGoruntuleme.Visible = true;
            pnlOgrenciGoruntuleme.Visible = false;
            pnlRaporlar.Visible = false;
            NotGoruntule();
            lblBilgi.Text = "Not Güncelleme";
        }

        private int GetCount(OleDbConnection cn, string query)
        {
            using(OleDbCommand cmd=new OleDbCommand(query,cn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void OgretmenForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListData();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            pnlRaporlar.Visible = true;
            pnlNotGoruntuleme.Visible = false;
            pnlOgrenciGoruntuleme.Visible = false;
            lblBilgi.Text = "Raporlar";

            using(OleDbConnection conn=new OleDbConnection(connectionString)){
                conn.Open();
                
                int toplamOgrenci=GetCount(conn, "select count(*) from Ogrenciler");
                int toplamOgretmen = GetCount(conn, "select count(*) from Ogretmenler");
                int toplamDers = GetCount(conn, "select count(*) from Dersler");

                lblToplamOgrenci.Text =toplamOgrenci.ToString();
                lblToplamOgretmen.Text = toplamOgretmen.ToString();
                lblToplamDers.Text = toplamDers.ToString();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
