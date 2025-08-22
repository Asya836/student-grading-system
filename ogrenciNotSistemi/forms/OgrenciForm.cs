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
    public partial class OgrenciForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public int ogrenciNo;
        public int ogrenciSifre;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\OgrenciNotSistemiDB.mdb";

        public OgrenciForm(string adSoyad)
        {
            InitializeComponent();
            label4.Text = adSoyad;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnKisiselBilgiler_Click(object sender, EventArgs e)
        {
            pnlKisiselBilgiler.Visible = true;
            pnlNotlar.Visible = false;
            label6.Text = "Kişisel Bilgiler";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "select * from Ogrenciler where Numara=@numara";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@numara", ogrenciNo);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lblOgrenciId.Text = reader["ID"].ToString();
                            lblOgrenciAd.Text = reader["Ad"].ToString();
                            lblOgrenciSoyad.Text = reader["Soyad"].ToString();
                            lblOgrenciNumara.Text = reader["Numara"].ToString();
                            lblOgrenciSifre.Text = reader["Sifre"].ToString();
                        }
                    }
                }
            }
        }

        private void OgrenciForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnNotlar_Click(object sender, EventArgs e)
        {
            pnlKisiselBilgiler.Visible = false;
            pnlNotlar.Visible = true;
            label6.Text = "Notlar";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "select * from Ogrenciler where Numara=@numara";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@numara", ogrenciNo);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lblTurkce.Text = reader["Turkce"].ToString();
                            lblMat.Text = reader["Matematik"].ToString();
                            lblFiz.Text = reader["Fizik"].ToString();
                            lblKim.Text = reader["Kimya"].ToString();
                            lblBiyo.Text = reader["Biyoloji"].ToString();
                        }
                    }
                }
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
