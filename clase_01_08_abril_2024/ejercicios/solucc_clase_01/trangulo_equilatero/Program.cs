namespace trangulo_equilatero
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa la altura del triangulo: ");
            string alturaIngresada = Console.ReadLine();
            int.TryParse(alturaIngresada, out int altura);

            for (int i = 1; i <= altura; i++)
            {
                string espacio = "";
                string asterisco = "";
                for (int j = 0; j <= altura - i; j++)
                {
                    espacio += " ";
                }
                for (int K = 0;  K < i * 2 - 1; K++)
                {
                    asterisco += "*";
                }
                Console.WriteLine(espacio + asterisco + espacio);
            }
        }
    }
}
