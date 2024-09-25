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
            List<string>orszag=new List<string>();
            foreach (var item in neplist)
            {
                if (!orszag.Contains(item.orszag))
                {
                    orszag.Add(item.orszag);
                }
            }
            Console.WriteLine($"{orszag.Count} db ország adatait tartalmazza a forrás");
            Console.ReadLine();
        }
    }
}
