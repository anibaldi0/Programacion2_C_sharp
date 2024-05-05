using System;


namespace desea_continuar
{
    internal class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta == "s") 
            {
                return true;
            }
            return false;
        }
        public static bool ValidarNumero(string numero)
        {
            if (int.TryParse(numero, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Sumar(int numero1, int numero2) 
        {
            int suma = numero1 + numero2;
            return suma;
        }
    }

}
