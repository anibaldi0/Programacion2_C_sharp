
/*
 * Proyecto: MiCalculadora
 * Archivo: Program.cs
 * Autor: Anibal Caeiro
 * Fecha de creación: 28/04/2024
 * Última modificación: 
 * Descripción: Este archivo contiene la clase principal del programa de calculadora.
 */

namespace desea_continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Ingrese el primer numero entero para ser sumado: ");
                string numero1Ingresado = Console.ReadLine();
                int.TryParse(numero1Ingresado, out int numero1);

                int primerNumero = 0;
                int segundoNumero = 0;
                if (Validador.ValidarNumero(numero1Ingresado))
                {
                    primerNumero = numero1;

                    bool segundoNumeroValido = false;
                    while (!segundoNumeroValido)
                    {
                        Console.WriteLine("Ingrese el segundo numero: ");
                        string numero2Ingresado = Console.ReadLine();
                        int.TryParse(numero2Ingresado, out int numero2);

                        if (Validador.ValidarNumero(numero2Ingresado))
                        {
                            segundoNumero = numero2;
                            segundoNumeroValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar un numero entero valido");
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Debe ingresar un numero entero valido");
                    continue;
                }

            int resultado = Validador.Sumar(primerNumero, segundoNumero);
            Console.WriteLine($"La suma de los 2 numeros es: {resultado}");

            Console.WriteLine("Desea continuar?: s/n");
            string respuesta = Console.ReadLine();
            continuar = Validador.ValidarRespuesta(respuesta);
            }

        }
    }
}
