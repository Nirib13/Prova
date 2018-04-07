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
            string x = InserisciNumero("Inserisci il primo numero");
            string y = InserisciNumero("Inserisci il secondo numero");

            if (x=="error" || y=="error")
            {
                Console.WriteLine("Valori non inseriti correttamente");
                AttendiChiusura();
            }
            else
            {
                int a = Int32.Parse(x);
                int b = Int32.Parse(y);
                Calcolatrice calcolatrice = new Calcolatrice(a, b);
                calcolatrice.Somma();
            }

            
            



            AttendiChiusura();
        }



        public static void AttendiChiusura()
        {
            Console.Write("Premi un tasto per uscire...");
            Console.ReadKey();
        }

        public static string InserisciNumero(String testoDaVisualizzare)
        {
            Console.WriteLine(testoDaVisualizzare);
            Console.ReadKey();
            bool bX = int.TryParse(Console.ReadLine(), out int x);
            
            if (bX==true)
            {
                return x.ToString();
            }
            else
            {
                return "error";
            }
        }
    }
}
