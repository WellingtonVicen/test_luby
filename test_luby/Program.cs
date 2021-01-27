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
            Console.WriteLine(" Preço com desconto R$:" + CalcularValorComDescontoFormatado("R$ 6.800,00", "30%"));
            Console.Write("Diferença em dias: " + CalcularDiferencaData("10122020", "25122020"));
            int[] vetor = new int[] { 2, 2, 2, 4, 2 };
            Console.WriteLine("Vetor com Pares:" + ObterElementosPares(vetor));

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

        static string CalcularDiferencaData(string data1 , string data2)
        {
            var dataCorrigida = data1.Insert(2, "-").Insert(5, "-");
            var dataCorrigida2 = data2.Insert(2, "-").Insert(5, "-");

            var dataConvertida = Convert.ToDateTime(dataCorrigida);

            
            var dataConvertida2 = Convert.ToDateTime(dataCorrigida2);

            TimeSpan diff = dataConvertida2.Subtract(dataConvertida);

            return diff.ToString("dd");

        }

        static string ObterElementosPares(int[] vetor)
        {
      
            List<int> par = new List<int>();

            for (int i = 1; i < vetor.Length; i++)
            {
                if(vetor[i] % 2 ==0)
                {   
                    par.Add(vetor[i]);
                }

            }

            int[] terms = par.ToArray();

            // conversao da array de int para string para retornar no console  
            string ids = String.Join(",", terms.Select(p => p.ToString()).ToArray());
            Console.WriteLine();
            return ids;

          
        }



    }
}
