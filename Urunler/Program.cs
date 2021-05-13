using System;

namespace Urunler
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Electronic = "Bilgisayar/Tablet";
            urun1.Moda = "Kadın";
            urun1.EvYasam = "Ev/Tekstil";
            urun1.Spor = "Spor Giyim&Ayakkabı";

            Urun urun2 = new Urun();
            urun2.Electronic = "Yazıcı&Projeksiyon";
            urun2.Moda = "Erkek";
            urun2.EvYasam = "Ofis/Kırtasiye";
            urun2.Spor = "Bisiklet";

            Urun urun3 = new Urun();
            urun3.Electronic = "Ev Tekstil";
            urun3.Moda = "Çanta";
            urun3.EvYasam = "Masaüstü";
            urun3.Spor = "Fitness";


            Urun[] urunler = new Urun[] {urun1,urun2,urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Electronic + ":" + urun.Moda + ":" + urun.EvYasam + ":" + urun.Spor);
            } 

           
            Console.WriteLine("sayfa sonu-footer");
            
            
        }
    }

    class Urun
    {
        public string Electronic { get; set; }
        public string Moda { get; set; }
        public string EvYasam { get; set; }
        public string Spor { get; set; }

    }
}
