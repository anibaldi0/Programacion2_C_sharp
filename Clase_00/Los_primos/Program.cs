using System;

namespace NumerosPrimos
{
    internal static class Program
    {
        public static void Main()
        {
            bool continuar = true;

            do
            {
                Console.WriteLine("Ingrese un número o escriba 'salir' para salir:");
                string input = Console.ReadLine();

                if (input.ToLower() == "salir")
                {
                    continuar = false;
                    break;
                }

                if (int.TryParse(input, out int numero))
                {
                    if (numero < 2)
                    {
                        Console.WriteLine("Ingrese un número mayor o igual a 2.");
                    }
                    else
                    {
                        MostrarNumerosPrimos(numero);
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un número válido o 'salir'.");
                }

                Console.WriteLine("¿Desea volver a operar? (si/no)");
                string respuesta = Console.ReadLine().ToLower();
                continuar = (respuesta == "s" || respuesta == "si");

            } while (continuar);

            Console.WriteLine("Hasta luego. Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        static void MostrarNumerosPrimos(int limite)
        {
            Console.WriteLine($"Números primos hasta {limite}:");
            for (int i = 2; i <= limite; i++)
            {
                if (EsPrimo(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static bool EsPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
