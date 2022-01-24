using System;

 namespace Tehtävä5_laskin
{
    class Program
    {
        static void Main(string[] args)
        { //Olioiden luonti
            float a = 5.0f;
            float b = 2.5f;

            //Metodien ja olioiden käyttö
            float summa = Laskin.Summa(a, b);
            float erotus = Laskin.Erotus(a, b);
            float tulo = Laskin.Tulo(a, b);
            float osamaara = Laskin.Osamaara(a, b);

            //Vastausten tulostus
            Console.WriteLine("Numeroiden {0} ja {1}:",a,b);
            Console.Write("Summa: " + summa);
            Console.Write(" Erotus: " + erotus);
            Console.Write(" Tulo: " + tulo);
            Console.Write(" Osamäärä: " + osamaara);


        }
    }

}

