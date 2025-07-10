using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Personel_Kayit
{
    public partial class Formistatistik : Form
    {
        public Formistatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=FATMANUR\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void Formistatistik_Load(object sender, EventArgs e)
        {
            // Toplam Personel Sayısı
            // count = saymak
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) From Table_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader(); //execute = uygula, execute reader = okuyucuyu çalıştır

            while (dr1.Read())
            {
                LblToplamPersonel.Text = dr1[0].ToString();
            }
            baglanti.Close();

            // Evli Personel Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select count(*) From Table_Personel where PerDurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                LblEvliPersonel.Text = dr2[0].ToString();
            }
            baglanti.Close();

            // Bekar Personel Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select count(*) From Table_Personel where PerDurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                LblBekarPersonel.Text = dr3[0].ToString();
            }
            baglanti.Close();

            // Şehir Sayısı
            // distinct = farklı --> kaç farklı şehir olduğunu gösterecek
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) From Table_Personel ", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                LblSehirSayisi.Text = dr4[0].ToString();
            }
            baglanti.Close();

            // Toplam Maaş
            // sum = toplam
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(PerMaas) From Table_Personel ", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();

            while (dr5.Read())
            {
                LblToplamMaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            // Ortalama Maaş
            // avg = ortalama
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select avg(PerMaas) From Table_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();

            while (dr6.Read())
            {
                LblOrtalamaMaas.Text = dr6[0].ToString();
            }
            baglanti.Close(); 
        }
    }
}
