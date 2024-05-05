
/*
 * Proyecto: MiCalculadora
 * Archivo: Program.cs
 * Autor: Anibal Caeiro
 * Fecha de creación: 28/04/2024
 * Última modificación: 
 * Descripción: Este archivo contiene la clase principal del programa de calculadora.
 */

namespace conversor_binario
{
    internal class Program
    {
        static void Main(string[] args)
        {



            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1- ¿Desea convertir un número binario a decimal?");
                Console.WriteLine("2- ¿Desea convertir un número decimal a binario?");
                Console.WriteLine("3- Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese un número binario: ");
                        string numBinarioIngresado = Console.ReadLine();
                        int decimalResult = Conversor.ConvertirBinarioADecimal(numBinarioIngresado);
                        Console.WriteLine($"El número binario ingresado es {numBinarioIngresado} y el equivalente en decimal es: {decimalResult}");
                        break;
                    case "2":
                        Console.WriteLine("Ingrese un número decimal: ");
                        string numeroDecimalIngresado = Console.ReadLine();
                        int.TryParse(numeroDecimalIngresado, out int numDecimal);
                        string binarioResultado = Conversor.ConvertirDecimalABinario(numDecimal);
                        Console.WriteLine($"El número decimal ingresado es {numDecimal} y el equivalente en binario es: {binarioResultado}");
                        break;
                    case "3":
                        continuar = false;
                        Console.WriteLine("Gracias por usar nuestro software");
                        break;
                    default:
                        Console.WriteLine("Opción invalida");
                        break;
                }
            }

        }
    }
}
