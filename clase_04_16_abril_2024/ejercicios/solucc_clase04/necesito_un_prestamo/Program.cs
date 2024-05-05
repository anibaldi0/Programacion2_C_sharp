
using prestamo;

namespace necesito_un_prestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta();
            cuenta.RealizarOperaciones();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGracias por elegir nuestro software");
            Console.ResetColor();
        }
    }
}
