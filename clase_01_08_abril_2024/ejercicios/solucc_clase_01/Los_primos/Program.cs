namespace Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
                ParsearNumero();
            } while (IngresarSiNo());
        }

            static bool IngresarSiNo()
            {
                Console.WriteLine("Desea ingresar otro numero? s/n");
                string respuesta = Console.ReadLine();

                if (respuesta == "s")
                {
                    return respuesta == "s";
                }
                else
                {
                Console.WriteLine("Gracias por usar nuestro software");
                return false;
                }
                
            }

            static int ParsearNumero()
            {
                Console.WriteLine("Ingrese un numero: ");
                string numero_ingresado = Console.ReadLine();

                if (int.TryParse(numero_ingresado, out int numero_parseado))
                {
                    Console.WriteLine($"Los numeros primos hasta el {numero_parseado} son: ");

                    for (int i = 2; i <= numero_parseado; i++)
                    {
                        if (NumeroPrimo(i))
                        {
                            Console.Write($"{i} "); //usar console.Write para que no haga salto de linea
                        }
                    }
                    Console.WriteLine(); //para que haga salto de linea al imprimir los numeros primos
                }
                else
                {
                    Console.WriteLine("Error: Ingrese un numero entero");
                }
                return numero_parseado;
            }

            static bool NumeroPrimo(int numero_parseado)
            {
                if (numero_parseado <= 1)
                {
                    return false;
                }    
                for (int i = 2; i <= Math.Sqrt(numero_parseado); i++)
                {
                    if (numero_parseado % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }

