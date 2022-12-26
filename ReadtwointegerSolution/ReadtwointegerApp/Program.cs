//Leer dos valores numéricos enteros y almacenarlos en dos variables de nombre `x' y `z', mostrando en aquellos casos en los que 'x' es mayor que `z' un mensaje que diga "Verdadero".
internal class Program
{
    private static void Main(string[] args)
    {
            int x = Leer("Ingrese Numero 1: ");
        int z = Leer("Ingrese Numero 2: ");

        if (x > z)
        Console.WriteLine ("Verdadero");
        else  
        Console.WriteLine ("Z es mayor que X");
    }

    public static int Leer(string mensaje)
  {
    for (int intentos = 0; intentos < 3; intentos++)
    {
        Console.WriteLine(mensaje);
            string numeroComoString = Console.ReadLine();
            int valorReal = 0;
            bool sePuedeConvertir = Int32.TryParse(numeroComoString, out valorReal);

            if (sePuedeConvertir)
            {
                return valorReal;
            }
            else
            {
                Console.WriteLine("valor ingresado invalido, intente de nuevo ...");
            }
    }
    throw new Exception("No se pude leer nada");
  }
}