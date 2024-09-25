using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg
{
    public class Nepesseg
    {
        public string orszag;
        public int terulet;
        public int nepesseg;
        public string fovaros;
        public int fo_nepesseg;
        public Nepesseg(string s)
        {
            string[] darab = s.Split(';');
            if (darab[2].Contains('g'))
            {
                int valt = int.Parse(darab[2].Replace('g', ' '));
                this.orszag = darab[0];
                this.terulet = int.Parse(darab[1]);
                this.nepesseg = valt * 10000;
                this.fovaros = darab[3];
                this.fo_nepesseg = int.Parse(darab[4]);
            }
            else
            {
                this.orszag = darab[0];
                this.terulet = int.Parse(darab[1]);
                this.nepesseg = int.Parse(darab[2]);
                this.fovaros = darab[3];
                this.fo_nepesseg = int.Parse(darab[4]);
            }
            
        }
    }
}
