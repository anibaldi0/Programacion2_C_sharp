
/*
 * Proyecto: MiCalculadora
 * Archivo: Program.cs
 * Autor: Anibal Caeiro
 * Fecha de creación: 28/04/2024
 * Última modificación: 
 * Descripción: Este archivo contiene la clase principal del programa de calculadora.
 */

using System;

namespace validador_de_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int minimo = 100;
            int maximo = -100;
            int suma = 0;

            Console.WriteLine("Cuantos datos desea ingresar?: ");
            string cantidadIngresada = Console.ReadLine();
            int.TryParse(cantidadIngresada, out int cantidadDatos);

            while (contador < cantidadDatos)
            {
                int numeroDato = contador + 1;
                Console.Write($"Ingrese el dato {numeroDato} entre -100 y 100: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    if (Validador.Validar(numero, -100, 100))
                    {
                        // Actualizar mínimo y máximo
                        if (numero < minimo)
                            minimo = numero;
                        if (numero > maximo)
                            maximo = numero;

                        // Sumar al total
                        suma += numero;

                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("El número ingresado no está dentro del rango válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número entero válido.");
                }
            }

            // Calcular promedio
            double promedio = (double)suma / 10;

            // Mostrar resultados
            Console.WriteLine("Valor mínimo ingresado: " + minimo);
            Console.WriteLine("Valor máximo ingresado: " + maximo);
            Console.WriteLine("Promedio de los números ingresados: " + promedio);

            Console.ReadLine();

        }
    }
}

