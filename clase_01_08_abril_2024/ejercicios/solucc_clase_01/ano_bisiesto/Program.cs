namespace ano_bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese ano inicial para calcular anos bisiestos: ");
            string numeroInicialIngresado = Console.ReadLine();
            int.TryParse(numeroInicialIngresado, out int anoInicial);

            Console.WriteLine("Ingrese el ano final para el calculo");
            string numeroFinalIngresado = Console.ReadLine();
            int.TryParse(numeroFinalIngresado, out int anoFinal);

            EsBisiesto(anoInicial, anoFinal);

        }

        static void EsBisiesto(int numero1, int numero2)
        {
            for (int i = numero1; i < numero2; i++)
            {
                if (EsMultiploDe_4_100_400(i))
                {
                    Console.WriteLine($"{i} es bisiesto");
                }
            }
        }

        static bool EsMultiploDe_4_100_400(int numero)
        {
            return numero % 4 == 0 && numero % 100 != 0 || numero % 400 == 0;
        }

    }
}
