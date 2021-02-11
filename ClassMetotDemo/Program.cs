using System;

namespace ClassMetotDemo
{
    /* Bir bankada müşteri takibi yapmak istiyorsunuz.
    Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
    MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz. */
    class Program
        {
        public static void Main(string[] args)
        {
         
            Musteri musteri1 = new Musteri();
            musteri1.Id = 13;
            musteri1.Adi = "Furkan";
            musteri1.Soyadi = "Yılmaz";
            musteri1.Meslek = "Bilgisayar Mühendisi";
            musteri1.KrediPuani = 95 / 100;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 17;
            musteri2.Adi = "Necati";
            musteri2.Soyadi = "Çevik";
            musteri2.Meslek = "Öğretmen";
            musteri2.KrediPuani = 85 / 100;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine("******************");


            }

            Console.WriteLine("-----------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("*****************");
            musteriManager.Ekle2(musteri1);
            musteriManager.Ekle2(musteri2);
            Console.WriteLine("*****************");
            musteriManager.Ekle3(musteri1);
            musteriManager.Ekle3(musteri2);

        }
    }
}
