using EnumOrnekProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOrnekProject
{
    public class Musteri
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string cinsiyet { get; set; }
        public string emailAdres { get; set; }

        public Musteri(int id, string isim, string soyisim, string cinsiyet, string emailAdres)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.cinsiyet = cinsiyet;
            this.emailAdres = emailAdres;
        }


        public static ArrayList musteriler = new ArrayList();


        public MusteriDurum musteriEkle(Musteri musteri)
        {
            musteriler.Add(musteri);


            return MusteriDurum.kayitBasarili;

        }


    }
}
