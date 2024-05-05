using System;

namespace numero_perfecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de numeros perfectos que desea encontrar: ");
            string cantidadIngresada = Console.ReadLine();
            int.TryParse(cantidadIngresada, out int cantidadNumerosPerfectos);

            Console.Write($"Los {cantidadNumerosPerfectos} primeros numeros perfectos son: ");
            List<int> numerosPerfectos = GuardarNumerosPerfectos(cantidadNumerosPerfectos);

            foreach(int numeroPerfecto  in numerosPerfectos)
            {
                Console.Write($"{numeroPerfecto} ");
            }

            Console.WriteLine();
        }
        static List<int> GuardarNumerosPerfectos(int cantidad_numeros)
        {
            List<int> numerosPerfectos = new List<int>();
            int numero = 1;
            while(numerosPerfectos.Count < cantidad_numeros)
            {
                if (EsNumeroPerfecto(numero))
                {
                    numerosPerfectos.Add(numero);
                }
                numero++;
            }
            return numerosPerfectos;
        }

        static bool EsNumeroPerfecto(int numero)
        {
            int suma = 0;
            for (int i = 1;  i <= numero - 1; i++)
            {
                if(numero % i == 0)
                {
                    //Console.Write($"{i} ");
                    suma += i;
/*                    if( suma == numero)
                    {
                        Console.WriteLine("Ha encontrado un numero perfecto");
                    }*/
                }
                
            }
            return suma == numero;
        }
    }

}
