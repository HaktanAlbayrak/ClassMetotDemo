using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public  void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla Eklendi " + musteri.Ad + " " + musteri.Soyad);
            
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla Silindi " + musteri.Ad + " " + musteri.Soyad);
            
        }
        
    }
}
