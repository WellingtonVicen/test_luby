using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace test_luby
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(CalcularFatorial(5));
            Console.WriteLine(CalcularPremio(100, "vip", null));
            Console.WriteLine(CalcularPremio(100, "basic", 3));
            Console.WriteLine(ContarPrimos(10));
            Console.WriteLine("Vogais: " + CalcularVogais("Luby Software"));
            Console.WriteLine("R$:" + CalcularValorComDescontoFormatado("R$ 6.800,00", "30%"));
    
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

        static int ContarPrimos(int numero)
        {
            int contador = 0;
            for (int i = 2; i <= numero; i++)
            {
                if(i == 2)
                {
                    //Console.WriteLine(i);
                    
                }
                else
                {
                    if (i % 2 == 0) continue;
                    else
                    {
                       // bool ePrimo = true;
                        contador++;
                        for (int j = 3; j < i /2; j++)
                        {
                            if(i % j == 0)
                            {
                                //ePrimo = false;
                                break;
                            }
                        }
                        //if (ePrimo) Console.WriteLine(i);
                        
                    }
                }
            }

            Console.Write("Total de números primos: ");
            return contador;
        }


         static int CalcularVogais(string palavra)
         {
            return palavra.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));
         }

        static string CalcularValorComDescontoFormatado(string dinheiro, string porcentagem)
        {
            string tratarDin = dinheiro.Replace("R$", "");
            double valorDin = Convert.ToDouble(tratarDin);

            string tratarPerc = porcentagem.Replace("%", "");
            int valorPorcent = Convert.ToInt32(tratarPerc);

            double a = valorPorcent / 100.0;

            double priceDesc = valorDin - (a * valorDin);

            return priceDesc.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
