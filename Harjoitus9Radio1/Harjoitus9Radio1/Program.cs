using System;

namespace Harjoitus9Radio1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Odotetaan haluttua kerrosta..");
            Radio hissi1 = new Radio();
            Console.WriteLine("Uusi kerros asetettu, poistu kirjoittamalla 'poistu' ");

            
            hissi1.valitseKerros();
            //kerroskutsu metodi hissi.cs luokassa


        }
    }
}
