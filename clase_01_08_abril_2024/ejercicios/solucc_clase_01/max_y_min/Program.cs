using System.Globalization;

namespace max_y_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero entero: ");
            string primer_numero = Console.ReadLine();
            int.TryParse(primer_numero, out int numero_01);

            Console.WriteLine("Ingrese el segundo numero entero: ");
            string segundo_numero = Console.ReadLine();
            int.TryParse(segundo_numero,out int numero_02);

            Console.WriteLine("Ingrese el tercer numero entero: ");
            string tercer_numero = Console.ReadLine();
            int.TryParse(tercer_numero,out int numero_03);

            Console.WriteLine("Ingrese el cuarto numero entero: ");
            string cuarto_numero = Console.ReadLine();
            int.TryParse(cuarto_numero,out int numero_04);

            Console.WriteLine("Ingrese el quinto numero entero: ");
            string quinto_numero = Console.ReadLine();
            int.TryParse(quinto_numero, out int numero_05);

            int numero_maximo = numero_01;
            int numero_minimo = numero_01;

            if (numero_02 > numero_maximo) {
                numero_maximo = numero_02;
                numero_minimo = numero_01;
            }
            if (numero_03 > numero_maximo){
                numero_maximo= numero_03;
            }
            if (numero_04 > numero_maximo) {
                numero_maximo=(numero_04);
            }
            if (numero_05 > numero_maximo){
                numero_maximo = numero_05;
            }
            if (numero_03 < numero_minimo)
            {
                numero_minimo = numero_03;
            }
            if (numero_04 < numero_minimo) {
                numero_minimo = numero_04;
            }
            if (numero_05 < numero_minimo) {
                numero_minimo = numero_05;
            }

            int suma = numero_01 + numero_02 + numero_03 + numero_04 + numero_05;

            decimal promedio = suma / 5;

            Console.WriteLine($"El numero maximo es {numero_maximo}");
            Console.WriteLine($"El numero minimo es {numero_minimo}");
            Console.WriteLine($"El promedio es {promedio}");
 
        }
    }
}
