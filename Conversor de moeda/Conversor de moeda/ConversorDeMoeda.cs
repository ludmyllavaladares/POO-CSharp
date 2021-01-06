using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor_de_moeda
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double real(double cotacao, double dolar)
        {
            double total = cotacao * dolar;
            return total + total * Iof / 100.0;
        }
    }
}
