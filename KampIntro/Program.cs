using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği
            // değer tutucu , alias

            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);

            /*int ogrenciSayisi = 32000;
            double faizOrani = 1.45;*/
            bool sistemeGirisYapmisMi = true;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }


            Console.WriteLine("***********Baska ornek*************");

            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }

        }
    }
}