namespace dibujar_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar altura del triangulo: ");
            string alturaIngresada = Console.ReadLine();
            int.TryParse(alturaIngresada, out int altura);

            string cadena = "";
            for (int i = 1; i <= altura; i++)
            {
                cadena += "*";
                Console.WriteLine($"{cadena}");
            }
        }
    }
}
