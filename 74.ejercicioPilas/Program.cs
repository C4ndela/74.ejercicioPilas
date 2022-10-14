using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74.ejercicioPilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabras;

            Stack<string> pila = new Stack<string>();

            Console.Write("Ingrese una cadena para almacenar en la pila: ");
            palabras = Console.ReadLine();


            while (palabras != string.Empty)
            {
                pila.Push(palabras);
                Console.Write("Ingrese la proxima cadena para almacenar en la pila: ");
                palabras = Console.ReadLine();
            }
            while (pila.Count > 0)
            {
                Console.WriteLine((string)pila.Pop());
            }

            Console.ReadKey();
        
        }
    }
}
