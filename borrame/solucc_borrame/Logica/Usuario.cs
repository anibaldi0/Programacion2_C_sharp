


namespace Logica
{
    public class Usuario
    {
        private string nombre;
        private string contrasena;

        public Usuario(string nombre, string contrasena)
        {
            this.nombre = nombre;
            this.contrasena = contrasena;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public bool ControlarPass(string pass)
        {
            return contrasena == pass;
        }
    }
}
