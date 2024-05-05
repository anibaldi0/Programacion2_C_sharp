
/*Nombre: Anibal Caeiro
 Docentes: Gustavo Rivas y Lautaro Galarza
Division: Lunes y martes 18:30hs*/

namespace aprende_las_tablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que tabla de multiplicar desea saber? ");
            Console.WriteLine("Ingrese un numero: ");
            string numeroIngresado = Console.ReadLine();
            double.TryParse(numeroIngresado, out double numero1);

            Console.WriteLine($"\nLa tabla de multiplicar del {numero1} es: ");

            StringBuilder.TablaDeMultiplicar(2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGracias por utilizar nuestro software");
            Console.ResetColor();
        }
    }
}
