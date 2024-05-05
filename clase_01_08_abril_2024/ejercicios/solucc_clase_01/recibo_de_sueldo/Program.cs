using System.Data;
using System.Data.Common;

namespace recibo_de_sueldo
{
    internal class Program
    {
 static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese total de empleados: ");
            string empleadosIngresados = Console.ReadLine();
            int.TryParse(empleadosIngresados, out int numeroEmpleados);

            for (int i = 1; i <= numeroEmpleados; i++)
            {

                Console.WriteLine("Ingrese el nombre del empleado: ");
                string nombreIngresado = Console.ReadLine();

                Console.WriteLine("Ingrese el valor de la hora: ");
                string valorIngresado = Console.ReadLine();
                double.TryParse(valorIngresado, out double valorHora);

                Console.WriteLine("Ingrese la antiguedad: ");
                string antiguedadIngresada = Console.ReadLine();
                int.TryParse(antiguedadIngresada, out int antiguedad);

                Console.WriteLine("Ingrese valor por la antiguedad: ");
                string valorAntiguedadIngresada = Console.ReadLine();
                int.TryParse(valorAntiguedadIngresada, out int valorAntiguedad);

                Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes: ");
                string horasIngresadas = Console.ReadLine();
                double.TryParse(horasIngresadas, out double cantidadHoras);

                Console.WriteLine("Ingrese el descuento en porcentaje: ");
                string descuentoIngresado = Console.ReadLine();
                double.TryParse(descuentoIngresado, out double porcentajeDescuento);

                Console.WriteLine($"Sr/a {nombreIngresado}");
                double valorHsMensuales = CalcularHorasTrabajadasPorCostoHora(valorHora, cantidadHoras);
                Console.WriteLine($"Importe por hs trabajadas al mes: ${valorHsMensuales}");
                Console.WriteLine($"Antiguedad: {antiguedad} anos");
                double totalAntiguedad = CalcularAntiguedadPorValorAno(antiguedad, valorAntiguedad);
                Console.WriteLine($"Importe por antiguedad es: ${totalAntiguedad}");


                double ingresoBruto = SueldoBruto(valorHsMensuales, totalAntiguedad);
                Console.WriteLine($"Ingreso Bruto: ${ingresoBruto}");
                double descuento = Descuentos(porcentajeDescuento);
                Console.WriteLine($"Descuentos: {descuento}%");
                double ingresoNeto = SueldoNeto(ingresoBruto, descuento);
                Console.WriteLine($"El sueldo neto es: ${ingresoNeto}");

            }


        }

        static double CalcularHorasTrabajadasPorCostoHora(double numero1, double numero2)
        {
            double valorHorasTrabajadas = 0;
            valorHorasTrabajadas = numero1 * numero2;

            return valorHorasTrabajadas;
        }

        static double CalcularAntiguedadPorValorAno(int numero1, double numero2)
        {
            double antiguedadPorValorAno = 0;
            antiguedadPorValorAno = numero1 * numero2;

            return antiguedadPorValorAno;
        }

        static double SueldoBruto(double numero1, double numero2)
        {
            double valorBruto = 0;
            valorBruto = numero1 + numero2;

            return valorBruto;
        }

        static double Descuentos(double numero1)
        {
            double descuento = 0;
            descuento = numero1;

            return descuento;
        }

        static double SueldoNeto(double numero1, double numero2)
        {
            double valorNeto = 0;
            //double descuento = numero1 * numero2; 
            valorNeto = numero1 - (numero1 * numero2 / 100);

            return valorNeto;
        }

    }
}
