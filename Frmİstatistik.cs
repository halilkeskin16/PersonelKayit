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
    public partial class Frmİstatistik : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GFGQKD6\\SQLEXPRESS;Initial Catalog=PersonelVeri;Integrated Security=True");
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            //Personel sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from Tbl_Personel",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblToplamPersonel.Text = dr1[0].ToString();
            }
            baglanti.Close();

            //Evli Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from Tbl_Personel where PErDurum = 1", baglanti);
            SqlDataReader d2 = komut2.ExecuteReader();
            while (d2.Read())
            {
                LblEvliPersonel.Text = d2[0].ToString();
            }
            baglanti.Close();

            //Bekar Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from Tbl_Personel where PErDurum = 0", baglanti);
            SqlDataReader d3 = komut3.ExecuteReader();
            while (d3.Read())
            {
                LblBekarPersonel.Text = d3[0].ToString();
            }
            baglanti.Close();

            //Farklı şehir sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(persehir)) from Tbl_Personel", baglanti);
            SqlDataReader d4 = komut4.ExecuteReader();
            while (d4.Read())
            {
                LblSehir.Text = d4[0].ToString();
            }
            baglanti.Close();

            //Toplam ödenen maaş sayısı
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(permaas) from Tbl_personel" , baglanti);
            SqlDataReader d5 = komut5.ExecuteReader();
            while (d5.Read())
            {
                LblToplamMaas.Text = d5[0].ToString(); 
            }
            baglanti.Close();

            //Ortalama maaş sayısı
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select avg(permaas) from Tbl_personel", baglanti);
            SqlDataReader d6 = komut6.ExecuteReader();
            while (d6.Read())
            {
                LblOrtalamaMaas.Text = d6[0].ToString();
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm form = new FrmAnaForm();
            form.Show();
            this.Hide();
        }
    }
}
