namespace BibliotecaPersonas
{
    public class Personas
    {

        private string nombre;
        private DateTime fechaNacimiento;
        private string dni;

        private Personas (string nombre, DateTime fechaNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public string GetNombre ()
        {
            return nombre;
        }

        public void SetNombre (string nombre)
        {
            this.nombre = nombre;
        }

        public DateTime GetFechaNacimiento ()
        {
            return fechaNacimiento;
        }

        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento= fechaNacimiento;
        }

        public string GetDni()
        {
            return dni;
        }

        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        



    }
}
