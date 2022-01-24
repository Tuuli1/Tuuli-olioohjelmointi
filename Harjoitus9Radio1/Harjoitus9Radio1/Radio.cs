using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9Radio1
{
    internal class Radio
    {
        private int Aanenvoimakkuus { get; set; }
        //private int Taajuus { get; set; }

        private int Voimakkuus;
        int uusiVoimakkuus;

        private int Taajuus;
        int uusiTaajuus;

        public void valitseKerros()
        {
            while (true)
            {
                Console.WriteLine("Tila: on ");
                //Äänen voimakkuus
                Console.WriteLine("Valitse äänenvoimakkuus 0-9 ");
                string annettuVoimakkuus = Console.ReadLine();

                if (annettuVoimakkuus.Equals("poistu"))
                {
                    break;
                }
                uusiVoimakkuus = int.Parse(annettuVoimakkuus);
                if (uusiVoimakkuus > 5)
                {

                    Console.WriteLine("Annettu äänenvoimakkuus on liian suuri");
                    uusiVoimakkuus = 0;
                }
                else if (uusiVoimakkuus < 0)
                {
                    Console.WriteLine("Annettu äänenvoimakkuus on liaan pieni");
                    uusiVoimakkuus = 0;
                }
                Console.WriteLine("Äänen voimakkuus: " + uusiVoimakkuus);
                Voimakkuus = uusiVoimakkuus;

                //Taajuus
                Console.WriteLine("Valitse taajuus 88.0 - 107.9 ");
                string annettuTaajuus = Console.ReadLine();

                if (annettuTaajuus.Equals("poistu"))
                {
                    break;
                }
                uusiTaajuus = int.Parse(annettuTaajuus);
                if (uusiTaajuus > 5)
                {

                    Console.WriteLine("Annettu kerros on liian suuri");
                    uusiTaajuus = 0;
                }
                else if (uusiTaajuus < 0)
                {
                    Console.WriteLine("Annettu kerros on liaan pieni");
                    uusiTaajuus = 0;
                }
                Console.WriteLine("Taajuus: " + uusiTaajuus);
                Taajuus = uusiTaajuus;

            }
            Console.WriteLine("Tila: off ");
        }
}    }
