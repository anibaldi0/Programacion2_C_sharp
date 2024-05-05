using System;
using Logica;

namespace ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool continuar = true;

            while (continuar)
            {

                Console.WriteLine("Ingrese Usuario: ");
                string usuarioIngresado = Console.ReadLine();

                Console.WriteLine("Ingrese contrasena: ");
                string contrasenaIngresada = Console.ReadLine();

                if (Sistema.ComprobarUsuario(usuarioIngresado, contrasenaIngresada))
                {
                    Console.WriteLine("Usuario Logueado");
                    //continuar = false;
                    
                    while (continuar)
                    {

                        Console.WriteLine("\nIngrese una opcion: ");
                        Console.WriteLine("1- Ingresar al sistema de datos");
                        Console.WriteLine("2- Ingresar al sistema de computo");
                        Console.WriteLine("3- Propiedades");
                        Console.WriteLine("4- Salir");

                        string opcion = Console.ReadLine();

                        switch (opcion)
                        {
                            case "1":
                                Console.WriteLine("Sistema de datos");
                                continuar = false;
                                break;
                            case "2":
                                Console.WriteLine("Sistema de Computo");
                                continuar = false;
                                break;
                            case "3":
                                Console.WriteLine("Propiedades");
                                continuar = false;
                                break;
                            case "4":
                                Console.WriteLine("\nSaliendo del sistema...");

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nGracias por usar nuestro software");
                                Console.ResetColor();

                                continuar = false;
                                break;
                            default:
                                Console.WriteLine("Elija la opcion correcta");
                                break;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Usuario desconocido");
                }

            }

            


        }
    }
}
