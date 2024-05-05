using System;

namespace Presentacion
{
    internal static class Error_al_cubo
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese un numero entero: ");
            string numero_ingresado = Console.ReadLine();

            if (double.TryParse(numero_ingresado, out double numero) && numero > 0)
            {
                double cuadrado = numero * numero;
                double cubo = numero * numero * numero;
                Console.WriteLine("El cuadrado del numero ingresado es {0}", cuadrado);
                Console.WriteLine("El cubo del numero ingresado es {0}", cubo);
            } else
            {
                Console.WriteLine("Incorrecto. Ingrese un numero entero mayor a cero ");
            }
        }
    }
}

