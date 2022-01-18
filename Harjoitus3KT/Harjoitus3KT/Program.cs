using System;

namespace Harjoitus3KT
{

    class Program
    {
        static void Main(string[] args)
        {
            // Olion luonti
            Kiuas kiuas1 = new Kiuas("Harvia", 80, 30);

            // Kutsutaan olion toimintoja ja määritellään uudet ominaisuudet
            kiuas1.MuutaToimintaa();
            kiuas1.tila = true;
            kiuas1.MuutaToimintaa();
            kiuas1.lämpötila = 80;
            kiuas1.kosteus = 50;
            kiuas1.MuutaToimintaa();

            


            //kiuas1.MuokkaaLämpötilaa(5);
            // kiuas1.MuokkaaKosteutta(80);
            //Public/private
            //toiminnot jotka ajetaan.

            //class programm, main metodi
            //tiedot hakeva metodi
            //halutaan tehtyä muuttava metodi
            //halutaan tiedot näkevä metodi
        }
    }
}
