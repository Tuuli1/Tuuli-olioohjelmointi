using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8_tyontekijajapomo
{
    //Henkilö luokka
    public abstract class Henkilo
    {//Henkilön ominaisuudet
        public abstract string Nimi { get; set; }
        public abstract string Tyopaikka { get; set; }
        public abstract int Palkka { get; set; }

        private static int instanssit = 0;

        public Henkilo()
        {
            instanssit++;
        }

        public abstract void Tiedot();

        public static void KuinkaMonta()
        {
            Console.WriteLine("Henkilöitä yhteensä " + instanssit);
        }
        public virtual void Tulostatiedot()
        {
            Console.Write("Henkilön tiedot: ");
        }
    }
}
