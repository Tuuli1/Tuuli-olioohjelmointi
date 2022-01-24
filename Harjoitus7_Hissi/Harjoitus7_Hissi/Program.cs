using System;

namespace Harjoitus7_Hissi
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Odotetaan haluttua kerrosta..");
            Hissi hissi1 = new Hissi();
            Console.WriteLine("Uusi kerros asetettu, poistu kirjoittamalla 'poistu' ");
            
            hissi1.Kerros.ToString();
            hissi1.valitseKerros();
            //kerroskutsu metodi hissi.cs luokassa
            
           
        }
    }
}
