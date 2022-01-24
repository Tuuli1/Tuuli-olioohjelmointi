using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus4
{
    internal class Kappale
    {
        public string Nimi;
        private string Kesto;

        public Kappale(string nimi, string kesto)
        {
            Nimi = nimi;
            Kesto = kesto;
        }

        public void GetData()
        {
            Console.WriteLine("Nimi: " + Nimi + " Kesto: " + Kesto);
        }

        //public string getData()
        //{
          //  return "---Nimi: " + this.kappale;
        //}
    }
}
