using System;

namespace Presentacion
{
    internal static class MaxMinPromedio
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese el primer número entero: ");
            string entrada_01 = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo número entero: ");
            string entrada_02 = Console.ReadLine();

            Console.WriteLine("Ingrese el tercer número entero: ");
            string entrada_03 = Console.ReadLine();

            Console.WriteLine("Ingrese el cuarto número entero: ");
            string entrada_04 = Console.ReadLine();

            Console.WriteLine("Ingrese el quinto número entero: ");
            string entrada_05 = Console.ReadLine();

            if (int.TryParse(entrada_01, out int numero_01) &&
                int.TryParse(entrada_02, out int numero_02) &&
                int.TryParse(entrada_03, out int numero_03) &&
                int.TryParse(entrada_04, out int numero_04) &&
                int.TryParse(entrada_05, out int numero_05))
            {
                int numero_maximo = numero_01;
                int numero_minimo = numero_01;

                if (numero_02 > numero_maximo)
                    numero_maximo = numero_02;
                if (numero_02 < numero_minimo)
                    numero_minimo = numero_02;

                if (numero_03 > numero_maximo)
                    numero_maximo = numero_03;
                if (numero_03 < numero_minimo)
                    numero_minimo = numero_03;

                if (numero_04 > numero_maximo)
                    numero_maximo = numero_04;
                if (numero_04 < numero_minimo)
                    numero_minimo = numero_04;

                if (numero_05 > numero_maximo)
                    numero_maximo = numero_05;
                if (numero_05 < numero_minimo)
                    numero_minimo = numero_05;

                decimal promedio = (decimal)(numero_01 + numero_02 + numero_03 + numero_04 + numero_05) / 5;
                Console.WriteLine("El promedio de los cinco números es: {0:N2}", promedio);

                Console.WriteLine("El número mínimo es: {0}", numero_minimo);
                Console.WriteLine("El número máximo es: {0}", numero_maximo);
                

            }
            else
            {
                Console.WriteLine("Número no válido, ingrese un número correcto");
            }
        }
    }
}
