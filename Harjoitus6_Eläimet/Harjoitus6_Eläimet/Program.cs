
using System;

namespace Harjoitus6_Eläimet
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira koira1 = new Koira();
            koira1.Ääntele();

            Kissa kissa1 = new Kissa();
            kissa1.Ääntele();

            Eläin.KuinkaMonta();
            Kissa.KuinkaMonta();
            Koira.KuinkaMonta();

            Koira koira2 = new Koira();

            Kissa kissa2 = new Kissa();
            Kissa kissa3 = new Kissa();

            Eläin.KuinkaMonta();
            Kissa.KuinkaMonta();
            Koira.KuinkaMonta();



        }
    }
}

