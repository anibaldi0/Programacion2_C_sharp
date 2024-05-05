using System;

namespace conversor_binario
{
    internal class Conversor
    {
        public static string ConvertirDecimalABinario(int numero)
        {
            if (numero == 0)
            {
                return "0";
            }
            string binario = " ";

            while (numero > 0)
            {
                int residuo = numero % 2;
                binario = residuo + binario;
                numero /= 2;
            }
            return binario;
        }

        public static int ConvertirBinarioADecimal(string numero)
        {
            int decimalResultado = 0;
            for (int i = numero.Length - 1; i >= 0; i--)
            {
                int digito = int.Parse(numero[i].ToString());
                decimalResultado += digito * (int)Math.Pow(2, numero.Length - 1 - i);
            }
            return decimalResultado;
        }        

    }
}
