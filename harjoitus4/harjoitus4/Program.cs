using System;

namespace harjoitus4
{

    class Program
    {
        static void Main(string[] args)
        {

            Albumi opiskelija1 = new Albumi("Imagine Dragons", "Evolve","pop rock", 10);
            opiskelija1.Lisääkappaleita(new Kappale("Next to me", "3,30"));
            opiskelija1.Lisääkappaleita(new Kappale("I don´t know why", "3,30"));
            opiskelija1.Lisääkappaleita(new Kappale("What ever it takes", "3,30"));
            opiskelija1.Lisääkappaleita(new Kappale("Believer", "3,30"));
            opiskelija1.Lisääkappaleita(new Kappale("Thunder", "3,30"));


            opiskelija1.TulostaData();
            
          // List<Kappale> kappale1 = new List<Kappale>();
          // kappale1.Add(new Kappale());
           //kappale1[0].Kappale = "Next to me";

           // kappale1.Add(new Kappale());
            //kappale1[1].Kappale = "I don´t know why";


            //foreach (Kappale kokoLista in kappale1)
            //{
            //    Console.WriteLine(kokoLista.getData());
            //}

            //Console.ReadLine();



            
        }
    }
}
