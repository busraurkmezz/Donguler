using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yaazılım Geliştirme Kampı", "Programlamaya Başlangıç" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfa sonnu-footer");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
