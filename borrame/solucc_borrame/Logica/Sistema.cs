using System;

namespace Logica
{
    public static class Sistema
    {
        static Usuario[] usuariosRegistrados;
        static Sistema() //constructor static de Sistema
        {
            usuariosRegistrados = new Usuario[8];
            CargarUsuarioHarcodeado();
        }

        private static void CargarUsuarioHarcodeado()
        {
            usuariosRegistrados[0] = new Usuario("Ani", "123");
            usuariosRegistrados[1] = new Usuario("Nachi", "765");
            usuariosRegistrados[2] = new Usuario("Pepe", "999");
        }



        public static bool ComprobarUsuario(string nombre, string pass)
        {

            if (string.IsNullOrEmpty(nombre.Trim()) || string.IsNullOrEmpty(pass.Trim()))
            {
                return false;
            }

            for (int i = 0; i < usuariosRegistrados.Length; i++)
            {
                if (usuariosRegistrados[i] != null)
                {
                    if (nombre.Trim().ToUpper() == usuariosRegistrados[i].GetNombre().Trim().ToUpper())
                    {
                        return (usuariosRegistrados[i].ControlarPass(pass)) ;
                    }
                }
            }

            return false;
        }

        

    }
}
