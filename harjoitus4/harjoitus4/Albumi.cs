using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus4
{
    internal class Albumi
    {
        public string Artisti;
        public string Nimi;
        public string Genre;
        public int Hinta;
        
       private List<Kappale> Kappaleet = new List<Kappale>();

        public Albumi(string _artisti,string _nimi, string _genre, int _hinta)
        {
            Artisti = _artisti;
            Nimi = _nimi;
            Genre = _genre;
            Hinta = _hinta;
        }

        public void Lisääkappaleita(Kappale kappale)
        {
            Kappaleet.Add(kappale);
        }
        public void TulostaKappaleet()
        {
            foreach (Kappale kappale in Kappaleet)
            {
                kappale.GetData();
            }
        }

        public void TulostaData()
        {
            Console.WriteLine("");
            Console.WriteLine("Albumi: ");
            Console.WriteLine("-Artisti: " + Artisti);
            Console.WriteLine("-Nimi: " + Nimi);
            Console.WriteLine("-Genre: " + Genre);
            Console.WriteLine("-Hinta: " + Hinta);
            
            Console.WriteLine("-Kappaleet: ");
            TulostaKappaleet();
            
           
           


        }

        //public void MuokkaaOpintopisteitä(int i)
        //{

          //  Hinta += i;

           // if (Hinta < 0)
           // {
           //     Hinta = 0;
           // }
        }
       
        
    }

    

    

