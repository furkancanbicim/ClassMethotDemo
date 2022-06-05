using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("{0} {1} isim ve soyisimli müşteri, {2} telefon numarasıyla birlikte eklendi ve id'si {3} verildi", musteri.Name, musteri.Surname,musteri.Phone,musteri.Id);
        }
        public void MusteriListele(List<Musteri> musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Adı : " + musteri.Name);
                Console.WriteLine("Soyadı : " + musteri.Surname);
                Console.WriteLine("Phone : " + musteri.Phone);
            }
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("{0} {1} isim ve soyisimli müşteri, {2} telefon numarasıyla birlikte silindi", musteri.Name, musteri.Surname, musteri.Phone);
        }
    }
}
