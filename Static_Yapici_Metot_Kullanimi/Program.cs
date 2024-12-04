using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Yapici_Metot_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kullanici k1 = new Kullanici(1, "Pınar", "Altınkaya");

            k1.bilgileriGoster();
            k1.zamYap(5000);
         
            Console.ReadLine();
        }
    }
}
