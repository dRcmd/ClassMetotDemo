using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(int id, string firstName, string lastName, decimal kasa)
        {
            new Musteri()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Kasa = kasa
            };
        }
    }
}
