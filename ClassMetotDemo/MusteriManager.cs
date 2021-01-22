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
            foreach (var musteri in musteriler)
            {
                if (musteri.Id == id)
                {
                    int indeks = musteriler.IndexOf(musteri);
                    Console.WriteLine("{0} indexteki {1} id Kayıt silindi!", indeks, musteri.Id);
                    musteriler.Remove(musteri);
                    break;
                }
                else
                {
                    Console.WriteLine("Kayıt Bulunamadı!!!!");
                }
            }


        }

        public void Guncelle(int id)
        {
            foreach (var musteri in musteriler)
            {
                if (musteri.Id == id)
                {
                    int indeks = musteriler.IndexOf(musteri);
                    Console.WriteLine("{0} indexteki {1} id {2} {3} adında kayıt bulundu. Kasası = {4}", indeks,
                        musteri.Id,musteri.FirstName,musteri.LastName,musteri.Kasa);
                    Console.Write("Neyi güncellemek istiyorsunuz? 1- Adı Soyadı 2-Kasa");
                    var secim = Console.ReadLine();
                    int secimInt=Convert.ToInt32(secim);
                    if (secimInt==1)
                    {
                        Console.Write("Yeni adı giriniz = ");
                        var updateFirstName = Console.ReadLine();
                        Console.Write("Yeni soyadı giriniz = ");
                        var updateLastName = Console.ReadLine();
                        musteriler[indeks].FirstName = updateFirstName;
                        musteriler[indeks].LastName = updateLastName;
                    }
                    else if (secimInt==2)
                    {
                        Console.Write("Yeni kasayı giriniz = ");
                        var updateKasa = Convert.ToInt32(Console.ReadLine());
                        musteriler[indeks].Kasa = updateKasa;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçim yaptınız!");
                    }
                    break;
                }
                
                else
                {
                    Console.WriteLine("Kayıt Bulunamadı!!!!");
                }
            }
        }
    }
}
