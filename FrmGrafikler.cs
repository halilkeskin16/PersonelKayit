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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GFGQKD6\\SQLEXPRESS;Initial Catalog=PersonelVeri;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("select PerSehir,Count(*) from Tbl_Personel group by PerSehir",baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();
            
            
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("select PerMeslek,Avg(PerMaas) from Tbl_Personel group by PerMeslek", baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frana = new FrmAnaForm();
            frana.Show();
            this.Hide();    
        }
    }
}
