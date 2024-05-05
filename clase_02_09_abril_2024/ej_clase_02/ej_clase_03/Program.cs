namespace Ejemplo

{
    public class Heroe
    {
        private string nombre;
        private decimal vida;
        private string habilidadEspecial;
        private decimal mana;
        private string clase;
        private DateTime fechaLogeo;
        private Guid codigoHeroe;

        public Heroe(string nombre, decimal vida, string habilidadEspecial, decimal mana, string clase)
        { 
            this.nombre = nombre;
            this.vida = vida;
            this.habilidadEspecial = habilidadEspecial;
            this.mana = mana;
            this.clase = clase;
            this.fechaLogeo = DateTime.Now;
            this.codigoHeroe = Guid.NewGuid();
        }

        public void SetNombre(string nuevoNombre)
        {
            this.nombre = $"{this.clase} {nuevoNombre}";
        }

    }
}
