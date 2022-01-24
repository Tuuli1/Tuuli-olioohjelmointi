using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus7_Hissi
{
    internal class Hissi
    {
        // Muuttujat
        private int kerros;
        int uusiKerros;
        

        public int Kerros
        {
            get => kerros;
            set
            {

                //metodi jota kutsutaan program.cs
                if (value > 5)
                {
                    Console.WriteLine("Annettu arvo oli liian suuri");
                    value = 5;
                }
                else if (value < 0)
                {
                    Console.WriteLine("Annettu arvo oli liian pieni");
                    value = 0;
                }

                Console.WriteLine("Olet kerroksessa " + value);
                kerros = value;
            }





        }
        public void valitseKerros()
        {
            while (true)
            {
                Console.WriteLine("Valitse kerros väliltä 1-5 ");
                string annettuKerros = Console.ReadLine();

                if (annettuKerros.Equals("poistu"))
                {
                    break;
                }
                uusiKerros =  int.Parse(annettuKerros);
                if (uusiKerros > 5)
                {
                    
                    Console.WriteLine("Annettu kerros on liian suuri");
                    uusiKerros = 0;
                }
                else if (uusiKerros < 0)
                {
                    Console.WriteLine("Annettu kerros on liaan pieni");
                    uusiKerros = 0;
                }
                Console.WriteLine("Olet kerroksessa " + uusiKerros);
                kerros = uusiKerros;

                bool result = int.TryParse(annettuKerros, out uusiKerros);
                

                if (result)
                {
                    
                   //hissi1.Kerros = uusiKerros;                   
                    kerros = uusiKerros;
                   // annettuKerros = uusiKerros;
                }
                else
                {
                    Console.WriteLine("Error: Annettu kerros oli virheellinen! Mikäli haluat poistua kirjoita 'poistu'");
                }
            }
            Console.WriteLine("Hissi on sammutettu");

        }
         
    }

}
