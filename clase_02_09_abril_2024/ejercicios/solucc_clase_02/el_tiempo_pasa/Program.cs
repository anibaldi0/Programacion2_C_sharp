namespace el_tiempo_pasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la fecha de nacimiento (dd/mm/aaaa):");
            string fechaNacimientoStr = Console.ReadLine();

            DateTime fechaNacimiento = DateTime.ParseExact(fechaNacimientoStr, "dd/MM/yyyy", null);

            int diasVividos = DiasPasados.CalcularDiasVividos(fechaNacimiento);

            Console.WriteLine($"La persona ha vivido {diasVividos} días hasta la fecha actual.");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGracias por usar nuestro software");
            Console.ResetColor();

        }
    }
}
