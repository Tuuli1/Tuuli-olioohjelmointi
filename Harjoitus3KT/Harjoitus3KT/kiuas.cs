using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3KT
{
    internal class Kiuas
    {
        //Atribuutit / ominaisuudet
       public string nimi { get; set; }
        public int kosteus { get; set; }
        public int lämpötila { get; set; }

        public bool tila;
        
        // Olion alustus
        public Kiuas(string _nimi, int _kosteus, int _lämpötila)
        {
            tila = false;
            kosteus = _kosteus;
            lämpötila = _lämpötila;
            nimi = _nimi;
        }

        
        // Olion toiminnot
        public void MuutaToimintaa()
        {

            Console.WriteLine("");

            if (tila == true)
            {
               
                
                Console.WriteLine("Kiuas: ");
                Console.WriteLine("Toiminta: on");
                Console.WriteLine("-- Nimi " + nimi);
                Console.WriteLine("-- kosteus: " + kosteus + "%");
                Console.WriteLine("-- lämpötila: " + lämpötila + "astetta");
            }
            else
            {
               Console.WriteLine("--Toiminta: off");
            }
        }

        
        }

    }

