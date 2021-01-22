using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();

        private Musteri musteri = new Musteri();
        //public Musteri Ekle(int id, string firstName, string lastName, decimal kasa)
        //{
        //    return new Musteri()
        //    {
        //        Id = id,
        //        FirstName = firstName,
        //        LastName = lastName,
        //        Kasa = kasa
        //    };
        //}
        public void Ekle(int id, string firstName, string lastName, decimal kasa)
        {
            musteriler.Add(new Musteri()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Kasa = kasa
            });
        }

        public void Listele()
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("{0} id, adı {1} {2}, kasa {3}",
                    musteri.Id,musteri.FirstName,musteri.LastName,musteri.Kasa);
            }
        }

        public void Sil(int id)
        {
            musteri.Id = id;
            musteriler.Remove(musteri.Id);

        }

        public void Guncelle()
        {

        }
    }
}
