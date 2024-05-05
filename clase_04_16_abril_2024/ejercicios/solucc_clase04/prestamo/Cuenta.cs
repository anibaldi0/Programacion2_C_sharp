namespace prestamo
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad = 0;

        public Cuenta()
        {
            this.titular = "Pepe";
            this.cantidad = 1000;
            
        }

        public string GetTitular ()
        {
            return titular;
        }

        public decimal GetCantidad ()
        {
            return cantidad;
        }

        public string MostrarCuenta ()
        {
            return $"Titular: {titular}\nCapital: {cantidad}\n";
        }

        public void IngresarMonto (decimal monto)
        {
            if (monto > 0)
            {
                cantidad += monto;
                Console.WriteLine($"Deposito realizado: {monto}\nSaldo actual: {cantidad}");
            }
            else
            {
                Console.WriteLine("Ingrese un monto mayor a cero");

            }

        }

        public void RetirarMonto (decimal monto)
        {
            if (monto > 0)
            {
                cantidad -= monto;
                Console.WriteLine($"Monto a retirar {monto}\nSu saldo es: {cantidad}");
            }
            else
            {
                Console.WriteLine("Ingrese un monto maytor a cero");
                
            }
        }

        public void RealizarOperaciones()
        {
            Console.WriteLine("Datos de la cuenta");
            Console.WriteLine(MostrarCuenta());

            Console.WriteLine("Ingrese un monto: ");
            string montoIngresado = Console.ReadLine();
            decimal.TryParse(montoIngresado, out decimal monto);

            Console.WriteLine("Ingrese el monto a retirar: ");
            string montoARetirar = Console.ReadLine() ;
            decimal.TryParse(montoARetirar, out decimal montoParseado);


            IngresarMonto(monto);
            RetirarMonto(montoParseado);
        }


    }
}




