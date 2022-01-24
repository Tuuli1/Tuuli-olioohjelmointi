using System;
using System.Collections.Generic;
using System.Text;



namespace Tehtävä5_laskin
{
    static class Laskin
    {
        //Laskin luokka
        //Laskujen kaavat/metodit joita kutsutaan Program.cs luokassa
        public static float Summa(float a, float b)
        { 
            return a + b;
        }

        public static float Erotus(float a, float b)
        { return a - b; }

        public static float Tulo(float a, float b)
        { return a * b; }

        public static float Osamaara(float a, float b)
        { return a / b; }

    }
}
