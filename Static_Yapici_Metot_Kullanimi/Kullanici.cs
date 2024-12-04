using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Yapici_Metot_Kullanimi
{
    public class Kullanici
    {
        private int kullaniciID { get; set; }
        private string isim { get; set; }
        private string soyisim { get; set; }
        private static int maas { get; set; }


        static Kullanici()
        {
            maas = 250000;
        }
        public Kullanici(int kullaniciid,string isim,string soyisim)
        {
            this.kullaniciID = kullaniciid;
            this.isim = isim;
            this.soyisim = soyisim;

        }
            
        public void bilgileriGoster()
        {
            Console.WriteLine("********* KULLANİCİ BİLGİLERİ **********");
            Console.WriteLine("İd : " + kullaniciID);
            Console.WriteLine("İsim : " + isim);
            Console.WriteLine("Soyisim : " + soyisim);
            Console.WriteLine("Maas : " + maas);
        }

        public void zamYap(int zamMiktari)
        {
            Console.WriteLine("Kullaniciya Zam Yapılıyor..");
            Console.WriteLine("Maaşı : " + maas);
            Console.WriteLine("Yeni Maaşı : " + (maas + zamMiktari));

        }

    }
}
