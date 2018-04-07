using Prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero");
            Console.ReadKey();
            bool bX= int.TryParse(Console.ReadLine(),out int x);

            Console.WriteLine("Inserisci il secondo numero");
            Console.ReadKey();
            bool bY = int.TryParse(Console.ReadLine(), out int y);


            Calcolatrice calcolatrice = new Calcolatrice(5, 10);
            



            AttendiChiusura();
        }



        public static void AttendiChiusura()
        {
            Console.Write("Premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}
