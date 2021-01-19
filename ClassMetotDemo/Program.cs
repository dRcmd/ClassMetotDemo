using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            void[] musteriler = new void[]
            {
                musteriManager.Ekle(1, "Ahmet", "Kutluay", 100.0m);
                musteriManager.Ekle(2, "Mustafa", "Kutluay", 100.0m);
                musteriManager.Ekle(3, "Ali", "Kutluay", 100.0m);

        };
           
            

        }
    }
}
