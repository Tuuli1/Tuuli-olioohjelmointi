using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8_tyontekijajapomo
{
    class Pomo : Henkilo
    {
       
        private static int instanssit = 0;
        public string Autonmerkki { get; set; }
        public int Bonuksenmaara { get; set; }

        public override string Nimi { get; set; }
        public override string Tyopaikka { get; set; }
        public override int Palkka { get; set; }

       
        public Pomo(string _nimi, string _tyopaikka, int _palkka, string _autonmerkki, int _bonustenmaara)
        {
            if (instanssit > 1)
            {
                //Tuhoa ylimääräinen Pomo
                return;
            }
            //instanssit++;


            Nimi = _nimi;
            Tyopaikka = _tyopaikka;
            Palkka = _palkka;
            Autonmerkki = _autonmerkki;
            Bonuksenmaara = _bonustenmaara;
        }

        
        public static new void KuinkaMonta()
        {         
            Console.WriteLine("Pomojen määrä: " + instanssit);
        }
        public override void Tulostatiedot()
        {
            Console.WriteLine("");
            Console.WriteLine("Auton merkki: " + Autonmerkki);
            Console.WriteLine("Bonukset: " + Bonuksenmaara);
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
