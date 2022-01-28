using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo1
{
    internal class MusteriManager
    {
        public void Listeleme(Musteri[] GelenDeger)
        {
            foreach (var listeler in GelenDeger)
            {
                Console.WriteLine(listeler.Ad);
            }
        }

        public void Ekle(Musteri Eklendi)
        {
            Console.WriteLine(Eklendi.Kidem);
        }
        
        public void Sil(Musteri Silme)
        {
            Console.WriteLine(Silme.id);
        }
    }
}
