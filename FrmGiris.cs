using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PersonelKayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GFGQKD6\\SQLEXPRESS;Initial Catalog=PersonelVeri;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Yonetici where KullaniciAd = @p1 and Sifre = @p2 ", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKullanici.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm frmana = new FrmAnaForm();
                frmana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            baglanti.Close();
        }

        private void cbsifre_CheckedChanged(object sender, EventArgs e)
        {
            if (cbsifre.Checked == true)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else if (cbsifre.Checked == false)
            {
                TxtSifre.UseSystemPasswordChar = true;
            }
        }
    }  
}