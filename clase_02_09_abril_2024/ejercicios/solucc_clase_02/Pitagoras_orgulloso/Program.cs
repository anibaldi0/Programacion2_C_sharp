
/*Nombre: Anibal Caeiro
 Docentes: Gustavo Rivas y Lautaro Galarza
Division: lunes y martes 18:30hs a  22:30hs*/

namespace Pitagoras_orgulloso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la base de un triangulo en cm: ");
            string baseIngresada = Console.ReadLine();
            double.TryParse(baseIngresada, out double baseTriangulo);

            Console.WriteLine("Ingrese la altura del triangulo en cm");
            string alturaIngresada = Console.ReadLine();
            double.TryParse(alturaIngresada, out double alturaTriangulo);


            double hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
            Console.WriteLine($"La hipotenusa del triangulo de base {baseTriangulo} cm y {alturaTriangulo} cm es {hipotenusa:N2} cm");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGracias por utilizar nuestro software");
            Console.ResetColor();

        }
    }
}
