namespace error_al_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ingrese un numero entero");
                string numero = Console.ReadLine();
                int.TryParse(numero, out int numero_entero);

                if (numero_entero > 0)
                {
                    int cuadrado = numero_entero * numero_entero;
                    int cubo = numero_entero * numero_entero * numero_entero;
                    Console.WriteLine($"El cuadrado de {numero_entero} es {cuadrado}");
                    Console.WriteLine($"El cubo del {numero_entero} es {cubo}");
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR: Reingresar numero");
                }
            }
        }
        

    }
}
