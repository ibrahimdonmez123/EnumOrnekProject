using EnumOrnekProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOrnekProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri(1, "iBO", "DÖNMEZ", "Erkek", "ibrahim@gmail.com");
           
            MusteriDurum donenDurum = musteri.musteriEkle(musteri);

            if (donenDurum == MusteriDurum.kayitBasarili)
            {
                Console.WriteLine("Müşteri başarılı bir şekilde eklenmiştir.");
            }
            else
            {
                Console.WriteLine("Müşteri bilgisi eklenememiştir.");

            }
            Console.ReadLine();


        }
    }
}
