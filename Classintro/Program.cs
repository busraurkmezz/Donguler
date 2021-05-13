using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs { };
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = "68" ;

            Kurs kurs2 = new Kurs { };
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = "100" ;

            Kurs kurs3 = new Kurs { };
            kurs3.KursAdi = "C++";
            kurs3.Eğitmen = "Ahmet";
            kurs3.IzlenmeOrani = "76";

            Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Eğitmen + ":" + kurs.IzlenmeOrani);
            }

            Console.WriteLine("sayfa sonu-footer");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }   //Class'lar veri tipi gibi düşünebiliriz
        public string Eğitmen { get; set; }   //string yerine kurslar diye bir tip oluşturmuş olduk
        public string IzlenmeOrani { get; set; }
    }
}
