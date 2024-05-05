using System;

namespace aprende_las_tablas
{
    internal class StringBuilder
    {
        public static void TablaDeMultiplicar(int numero1)
        {
            for (int i = 1; i < 10; i++)
            {
                double resultado = numero1 * i;
                Console.WriteLine($"{numero1} X {i} = {resultado}");
            }
            
        }
    }
}
