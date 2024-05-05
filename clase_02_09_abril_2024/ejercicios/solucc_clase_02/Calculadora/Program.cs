
/*
 * Proyecto: MiCalculadora
 * Archivo: Program.cs
 * Autor: Anibal Caeiro
 * Fecha de creación: 28/04/2024
 * Última modificación: 
 * Descripción: Este archivo contiene la clase principal del programa de calculadora.
 */

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Desea hacer una operacion? s/n");
                string respuestaIngresada = Console.ReadLine();

                if (respuestaIngresada == "s")
                {
                    double numero1;
                    do {
                        Console.WriteLine("Ingresa el primer numero: ");
                        string primerNumeroIngresado = Console.ReadLine();

                        if (!double.TryParse(primerNumeroIngresado, out numero1))
                        {
                            Console.WriteLine("Debe ingresar un número válido.");
                        }
                        else
                        {
                            break;
                        }
                    } while (continuar);

                    Console.WriteLine("Que operacion desea?: ");
                    Console.WriteLine("1- suma");
                    Console.WriteLine("2- resta");
                    Console.WriteLine("3- multiplicacion");
                    Console.WriteLine("4- division");

                    string operacion = Console.ReadLine();

                    double numero2;
                    do
                    {
                        Console.WriteLine("Ingresa el segundo numero: ");
                        string segundoNumeroIngresado = Console.ReadLine();
                        double.TryParse(segundoNumeroIngresado, out numero2);

                        if (operacion == "4" && numero2 == 0)
                        {
                            Console.WriteLine("El segundo numero no puede ser cero");
                        }
                    } while (operacion == "4" && numero2 == 0);

                    double resultado = Calculadora.Calcular(numero1, numero2, operacion);
                    Console.WriteLine($"El resultado es {resultado}");

                }
                else if (respuestaIngresada == "n")
                {
                    Console.WriteLine("Gracias por usar nuestro software");
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("Respuesta no válida. Por favor, ingrese 's' o 'n'.");
                }
            }
        }
    }
}
