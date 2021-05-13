using System;
using System.Collections.Generic;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product product1 = new Product();
            //product1.Id = 1;
            //product1.CategoryId = 2;
            //product1.ProductName = "Masa";
            //product1.UnitPrice = 500;
            //product1.UnitInStock = 3;

            //ProductManager productManager = new ProductManager();
            //productManager.Topla2(3,6);                            //bunun sonucunu daha sonra kullanamam

            //int toplamaSonucu = productManager.Topla(3,6);
            //Console.WriteLine(toplamaSonucu*2);
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);  // isimler e başka bir adres tanımladığımız için atık yeni adreste sadece ilker var
                                            //bu yüzden list kullanıyoruz, daha önceki verileri de tutabilmek için


            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Engin");        //listeye eleman  ekliyorum

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);                                     //list ile önceki adresi kaybetmedik

            //MyList<string> isimler1 = new MyList<string>();
            //isimler1.Add("Engin");                                               //eleman ekledik



            List<string> sehirler = new List<string> ();
            //sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler1 = new MyList<string>();
            sehirler1.Add("Ankara");
            sehirler1.Add("Ankara");
            Console.WriteLine(sehirler1.Count);
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
            



    }
    }
}
