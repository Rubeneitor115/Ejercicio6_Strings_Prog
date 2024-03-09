/***
 * Ruben Bernal Ramos
 * CSI1
 */

namespace Ejercicio6_Strings_Prog
{
    /// <summary>
    /// Clase principal de la aplicación
    /// rbr - 090324
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// rbr - 090324
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Declaro las variables
            string frase;
            List<string> lista;

            //Pido la clase por consola
            Console.WriteLine("Introduzca una Frase: ");
            frase = Console.ReadLine();

            //Muestro por consola la frase introducida
            Console.WriteLine("Frase introducida: ");
            Console.WriteLine(frase);

            //Invierto la frase y la muestro por consola
            char[] charArray = frase.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine("Frase invertida: ");
            foreach (char caracter in charArray)
            {
                Console.Write(caracter);
            }
        }
    }
}