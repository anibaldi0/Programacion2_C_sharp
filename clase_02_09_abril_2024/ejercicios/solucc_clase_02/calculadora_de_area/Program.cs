
/*Nombre: Anibal Caeiro
 Docentes: Gustavo Rivas y Lautaro Galarza
Division: lunes y martes 18:30hs a  22:30hs*/

namespace calculadora_de_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Que area desea saber?");
                Console.WriteLine("1- Area del cuadrado");
                Console.WriteLine("2- Area del triangulo");
                Console.WriteLine("3- Area del circulo");
                Console.WriteLine("4- Salir\n");

                Console.WriteLine("Ingrese su opcion");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese longitud del lado del cuadrado");
                        string ladoIngresado = Console.ReadLine();
                        double.TryParse(ladoIngresado, out double ladoCuadrado);
                        //CalculadoraDeArea.CalcularAreaCuadrado(ladoCuadrado);
                        Console.WriteLine($"El area del cuadrado es {CalculadoraDeArea.CalcularAreaCuadrado(ladoCuadrado)}\n");
                        break;
                    case "2":
                        Console.WriteLine("Ingrese la base del triangulo");
                        string baseIngresada = Console.ReadLine();
                        double.TryParse(baseIngresada, out double baseTriangulo);
                        Console.WriteLine("Ingrese la altura del triangulo");
                        string alturaIngresada = Console.ReadLine();
                        double.TryParse(baseIngresada, out double alturaTriangulo);
                        //CalculadoraDeArea.CalcularAreaCuadrado(ladoCuadrado);
                        Console.WriteLine($"El area del triangulo es {CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo)}\n");
                        break;
                    case "3":
                        Console.WriteLine("Ingrese longitud del radio del circulo");
                        string radioIngresado = Console.ReadLine();
                        double.TryParse(radioIngresado, out double radioCirculo);
                        //CalculadoraDeArea.CalcularAreaCuadrado(ladoCuadrado);
                        Console.WriteLine($"El area del cuadrado es {CalculadoraDeArea.CalcularAreaCirculo(radioCirculo)} \n");
                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nGracias por utilizar nuestro software");
                        Console.ResetColor();
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.\n");
                        break;

                }
                
            }
            
        }
    }
}
