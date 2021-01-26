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
            
            Console.WriteLine(CalcularFatorial(5));
            Console.WriteLine(CalcularPremio(100, "vip", null));
            Console.WriteLine(CalcularPremio(100, "basic", 3));
            Console.WriteLine(CalcularPremio(100, "premium", 1));
            Console.WriteLine(CalcularPremio(100, "deluxe", 1));
            Console.WriteLine(CalcularPremio(100, "special", 1));
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

        static  double CalcularPremio(int number, string mod, double? quantity)
        {
           
            if (quantity == null)
            {
                quantity = 1;
            }
            if(mod == "basic")
            {
                return (double)(number * 1 * quantity);
            }
            else if (mod == "vip")
            {
                return (double)(number * 1.2 * quantity);
            }
            else if (mod == "premium")
            {
                return (double)(number * 1.5 * quantity);
            }
            else if (mod == "deluxe")
            {
                return (double)(number * 1.8 * quantity);
            }
            else if (mod == "special")
            {
                return (double)(number * 2 * quantity);
            }

           
              return number;
           

        }
    }
}
