using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8_tyontekijajapomo
{
    internal class Tyontekija : Henkilo
    {
        private static int instanssit = 0;
        public int Tunnitviikossa { get; set; }

        public override string Nimi { get; set; }
        public override string Tyopaikka { get; set; }
        public override int Palkka { get; set; }

        public Tyontekija(string _nimi, string _tyopaikka, int _palkka, int _tunnitviikossa)
        {
            instanssit++;
            Nimi = _nimi;
            Tyopaikka = _tyopaikka;
            Palkka = _palkka;
            Tunnitviikossa = _tunnitviikossa;
            
        }
        public Tyontekija()
        {
            instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Työntekijöiden määrä: " + instanssit);
        }

        public override void Tulostatiedot()
        {
            Console.WriteLine("");
            Console.WriteLine("Työtunnit per viikko: " + Tunnitviikossa);
            Tiedot();

        }
        public override void Tiedot()
        {
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Työpaikka: " + Tyopaikka);
            Console.WriteLine("Palkka: " + Palkka);
            Console.WriteLine(" ");

        }
       
    }
}

