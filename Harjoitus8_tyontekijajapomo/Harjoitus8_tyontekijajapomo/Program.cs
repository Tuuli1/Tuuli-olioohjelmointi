using System;

namespace Harjoitus8_tyontekijajapomo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pomo pomo1 = new Pomo("","", 0,"",0);
            Pomo pomo2 = new Pomo("Antti","",0,"",0);

            Tyontekija työntekijä1 = new Tyontekija("Minna", "Careeria", 2500, 30);
            Tyontekija työntekijä2 = new Tyontekija("Sanna", "Careeria", 300, 30);

            pomo1.Tyopaikka = "Careeria";
            pomo1.Autonmerkki = "Toyota";
            pomo1.Palkka = 80;
            pomo1.Nimi = "Mikko";
            pomo1.Tulostatiedot();

            
            työntekijä1.Tulostatiedot();

            työntekijä2.Tulostatiedot();

            pomo2.Tulostatiedot();


            Tyontekija.KuinkaMonta();
            Pomo.KuinkaMonta();
            Henkilo.KuinkaMonta();
           

            



        }
    }
}
