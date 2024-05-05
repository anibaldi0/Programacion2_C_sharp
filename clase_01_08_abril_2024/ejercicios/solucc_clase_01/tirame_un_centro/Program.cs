using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el limite final para calcular el centro numerico");
        string numeroIngresado = Console.ReadLine();
        int.TryParse(numeroIngresado, out int limite);

        //Console.WriteLine($"Los centros numericos hasta el {limite} son: ");
        CalcularCentrosNumericos( limite );
        
        static void CalcularCentrosNumericos(int numero)
        {
            bool centroEncontrado = false;

            for (int i = 1; i <= numero ; i++)
            {
                long sumaAntes = SumaSecuencial(i - 1);
                long sumaDespues = SumaSecuencial(numero) - sumaAntes - i;
                if (sumaAntes == sumaDespues)
                {
                    Console.WriteLine($"El centro numerico encontrado hasta el {numero} es: ");
                    Console.WriteLine($"Centro numerico: {i}");
                    Console.WriteLine($"Suma izquierda es {sumaAntes}");
                    Console.WriteLine($"Suma derecha es {sumaDespues}");
                    centroEncontrado= true;
                }

            }

            if (! centroEncontrado )
            {
                Console.WriteLine("No hay centro numerico");
            }

        }

        static long SumaSecuencial(int numero)
        {
            return (long)numero * (numero + 1) / 2;
        }

    }

}
