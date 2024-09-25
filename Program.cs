 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Nepesseg> neplist = new List<Nepesseg>();
            StreamReader sr = new StreamReader("adatok-utf8.txt");
            string headline=sr.ReadLine();
            while (!sr.EndOfStream)
            {
                neplist.Add(new Nepesseg(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("3.feladat:");
            int ossz = 0;
            foreach (var item in neplist)
            {
                ossz++;
            }
            Console.WriteLine($"{ossz} db ország adatait tartalmazza a forrás.");
            Console.WriteLine();
            Console.WriteLine("4.feladat:");
            foreach (var item in neplist)
            {
                if (item.orszag=="Kína")
                {
                    Console.WriteLine($"Kína népsűrűsége {item.nepesseg/item.terulet} fő/km^2.");
                }
            }
            Console.WriteLine();
            Console.WriteLine("5.feladat:");
            int indlak = 0;
            int kinlak = 0;
            foreach(var item in neplist)
            {
                if (item.orszag=="India")
                {
                    indlak = item.nepesseg;
                }
                if (item.orszag=="Kína")
                {
                    kinlak=item.nepesseg;
                }
            }
            Console.WriteLine($"Kínában a lakosság {kinlak-indlak} fővel volt több.");
            Console.WriteLine();
            Console.WriteLine("6.feladat:");
            int harmadik_lak = 0;
            string harmadik_nev = "";
            foreach(var item in neplist)
            {
                if(item.nepesseg<indlak&&item.nepesseg<kinlak&&item.nepesseg>harmadik_lak)
                {
                    harmadik_lak=item.nepesseg;
                    harmadik_nev = item.orszag;
                }
            }
            Console.WriteLine($"A harmadik legnépesebb ország: {harmadik_nev}, lakossága {harmadik_lak} fő.");
            Console.ReadLine();
        }
    }
}
