using System;

namespace validador_de_rangos
{
    internal class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }
    }
}

