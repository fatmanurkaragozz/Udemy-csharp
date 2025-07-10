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
    public partial class FormGrafikler : Form
    {
        public FormGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=FATMANUR\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void FormGrafikler_Load(object sender, EventArgs e)
        {
            // Grafik 1
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("select PerSehir, count(*) from Table_Personel group by PerSehir", baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();

            // SqlDataReader: Veritabanından okunan verileri satır satır tutmak için kullanılan sınıf
            // ExecuteReader(): Sorguyu yürütür ve sonucu SqlDataReader nesnesi olarak döndürür    

            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

            // Grafik 2
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("select PerMeslek, avg(PerMaas) From Table_Personel group by PerMeslek", baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();

            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();

        }
    }
}
