using System;

namespace Harjoitus2
{

    class Program
    {
        static void Main(string[] args)
        {

            Opiskelija opiskelija1 = new Opiskelija("Matti", "TVT1234", 0);

            opiskelija1.TulostaData();
            opiskelija1.MuokkaaOpintopisteitä(5);
            opiskelija1.TulostaData();
        }
    }
}

