
/*Nombre: Anibal Caeiro
 Docentes: Gustavo Rivas y Lautaro Galarza
Division: lunes y martes 18:30hs a  22:30hs*/

namespace calcular_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero para calcular su factorial: ");
            string numeroIngresado = Console.ReadLine();
            int.TryParse(numeroIngresado, out int numero);

            CalculadoraFactorial.CalcularFactorial(numero);
            Console.WriteLine($"El factorial de {numero} es {CalculadoraFactorial.CalcularFactorial(numero)}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGracias por usar nuestro software");
            Console.ResetColor();
        }
    }
}
