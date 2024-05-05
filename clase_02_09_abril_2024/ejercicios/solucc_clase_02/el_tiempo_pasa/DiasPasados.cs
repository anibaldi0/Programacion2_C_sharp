using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace el_tiempo_pasa
{
    internal class DiasPasados
    {
        public static int CalcularDiasVividos(DateTime fechaNacimiento)
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Today;

            // Calcular la diferencia entre la fecha actual y la fecha de nacimiento
            TimeSpan diferencia = fechaActual - fechaNacimiento;

            int diasTranscurridos = diferencia.Days;

            // Ajustar los días si hay años bisiestos entre las fechas
            for (int i = fechaNacimiento.Year; i < fechaActual.Year; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    diasTranscurridos++;
                }
            }

            return diasTranscurridos;
        }
    }
}
