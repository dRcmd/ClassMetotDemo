using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(1, "Ahmet", "Kutluay", 100.0m);
            musteriManager.Ekle(2, "Agah", "Kutluay", 200.0m);
            musteriManager.Ekle(3, "Ali", "Kutluay", 232.0m);

            musteriManager.Listele();
            musteriManager.Sil(2);
            musteriManager.Listele();
            musteriManager.Guncelle(1);
            musteriManager.Listele();
            
        }
    }
}
