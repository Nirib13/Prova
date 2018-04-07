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

            if (x.Equals("error") | y.Equals("error"))
            {
                Console.WriteLine("Valori non inseriti correttamente");
                
            }
            else
            {
                int a = Int32.Parse(x);
                int b = Int32.Parse(y);
                Calcolatrice calcolatrice = new Calcolatrice(a, b);
                calcolatrice.Somma();
                calcolatrice.Differenza();
                calcolatrice.Moltiplicazione();
                calcolatrice.Divisione();
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
            bool bX = int.TryParse(Console.ReadLine(), out int x);
            Console.WriteLine("bsejufajs");

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
