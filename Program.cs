using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1900_contar_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        
            Console.WriteLine("Contar de 1 até 10");

            Console.WriteLine();

            for (int contador = 1; contador <= 9; contador++)
            {

                Console.Write(contador + ", ");

            }

            Console.WriteLine("10.");
            Console.ReadLine();

        }
    }
}
