using System;

namespace Harjoitus1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Olio ajoneuvo luokasta
            Ajoneuvot auto = new Ajoneuvot();

            //Asetetaan oliolle auto arvot
            auto.Nimi = "Toyota";
            auto.Nopeus = 160;
            auto.Renkaat = 4;

            //Käytetään auto olion toimintoja
            auto.TulostaData();

            string autonTiedot = auto.ToString();
            Console.WriteLine(autonTiedot);

            Console.WriteLine();

            Ajoneuvot mopo = new Ajoneuvot();
            mopo.Nimi = "Skootteri";
            mopo.Nopeus = 55;
            mopo.Renkaat = 2;

            mopo.TulostaData();
            Console.Write(mopo.ToString());
        }
    }
}
