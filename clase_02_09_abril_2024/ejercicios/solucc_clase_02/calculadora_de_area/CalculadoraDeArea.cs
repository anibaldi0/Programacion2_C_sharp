using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_area
{
    internal class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double areaCuadrado = longitudLado * longitudLado;
            return areaCuadrado;
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            double areaTriangulo = baseTriangulo * altura;
            return areaTriangulo;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double areaCirculo = 3.14 * radio * radio;
            return areaCirculo;
        }

    }
}
