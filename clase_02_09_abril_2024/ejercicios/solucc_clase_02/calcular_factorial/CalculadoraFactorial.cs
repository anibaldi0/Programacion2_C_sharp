using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_factorial
{
    internal class CalculadoraFactorial
    {
        public static long CalcularFactorial(int numero)
        {
            long factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
