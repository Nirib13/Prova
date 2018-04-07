using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Models
{
    interface Calcolatrice
    {
        int Somma(int x, int y);
        int Differenza(int x, int y);
        int Moltiplicazione(int x, int y);
        double Divisione(int x, int y);
    }
}
