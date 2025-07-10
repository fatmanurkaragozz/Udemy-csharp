using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeachExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Sayılar giriniz ve butona tıklayınız. ");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Check if the input is "0"
            if (textBox1.Text == "0")
            {
                MessageBox.Show("0 girildi, artık sayı girilemez.");
                textBox1.Enabled = false; // Disable the text box
                button1.Enabled = false;  // Disable the button
                button2.Enabled = true; // 4'e tam bölünenleri gösterme butonunu etkinleştir
                return;
            }

            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // ListBox'taki tüm öğeleri bir int dizisine eklemek
            int[] dizi = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (int.TryParse(listBox1.Items[i].ToString(), out int sayi))
                {
                    dizi[i] = sayi;
                }
                else
                {
                    MessageBox.Show("Lütfen yalnızca tam sayılar giriniz");
                }
            }

            // 4' e tam bölünen sayıları gösterme
            listBox1.Items.Add("------");
            foreach (int sayi in dizi)
            {
                if (sayi % 4 == 0)
                {
                    listBox1.Items.Add(sayi + " 4'e tam bölünüyor! ");
                }
            }

            button2.Enabled = false; // Tekrar 4'e bölünenleri göstermeyi engelle
        }
    }
}
