using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Haktan";
            musteri1.Soyad = "Albayrak";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Melike";
            musteri2.Soyad = "İrgin";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

            foreach  (var Musteri in musteriler )
            {
                Console.WriteLine("Müşteri AD :" + Musteri.Ad);
                Console.WriteLine("Müşteri Soyad :" + Musteri.Soyad);
            }
        }
    }
}
