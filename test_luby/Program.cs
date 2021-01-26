using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_luby
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tou de Volta Porra !!");
            Console.WriteLine(CalcularFatorial(5));

            Console.ReadLine();

        }

        static long CalcularFatorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * CalcularFatorial(number - 1);
            }
        }
    }
}
