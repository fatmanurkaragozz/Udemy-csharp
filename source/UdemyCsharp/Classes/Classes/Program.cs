using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        // Static sayaç
        private static int kisiSayaci = 0;

        static void Main(string[] args)
        {
            // İlk kişi
            Program kisi1 = new Program();
            kisi1.Bilgiler("Fatma Nur", "Karagöz", 19, "Mühendis");

            // İkinci kişi
            Program kisi2 = new Program();
            kisi2.Bilgiler("Ahmet", "Yılmaz", 25, "Doktor");

            // Üçüncü kişi
            Program kisi3 = new Program();
            kisi3.Bilgiler("Zeynep", "Aksoy", 30, "Avukat");
        }

        // Constructor
        public Program()
        {
            // Yeni kişi oluşturulduğunda sayaç artırılıyor
            kisiSayaci++;
            Console.WriteLine($"{kisiSayaci}.kişi:");
        }

        public void Bilgiler(string ad, string soyad, int yas, string meslek)
        {
            
            Console.WriteLine($"İsminiz: {ad}, Soyadınız: {soyad}, Yaşınız: {yas}, Mesleğiniz: {meslek}");
            Console.ReadLine();
        }

       
    }
}
