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
            Console.ReadLine();
        }
    }
}
