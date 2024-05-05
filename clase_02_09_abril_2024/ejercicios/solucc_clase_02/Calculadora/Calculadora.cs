using System;

namespace Calculadora
{
    public class Calculadora
    {
        public static double Calcular(double numero1, double numero2, string operacion)
        {
            double resultado = 0;
            bool continuar = true;

            switch (operacion)
            {
                case "1":
                    resultado = numero1 + numero2;
                    break;
                case "2":
                    resultado = numero1 - numero2;
                    break;
                case "3":
                    resultado = numero1 * numero2;
                    break;
                case "4":
                    if (Validar(numero2))
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. Division por cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Operacion no valida");
                    break;

                    
            }
            return resultado;
        } 

        public static bool Validar(double numero2)
        {

            if (numero2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
