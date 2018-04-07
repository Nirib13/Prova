using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Models
{
    class Calcolatrice: ICalcolatrice
    {
        int x;
        int y;

        public Calcolatrice(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Differenza(int x, int y)
        {
            return x - y;
        }

        public double Divisione(int x, int y)
        {
            return x / y;
        }

        public int Moltiplicazione(int x, int y)
        {
            return x * y;
        }

        public int Somma(int x, int y)
        {
            return x + y;
        }
    }
}
