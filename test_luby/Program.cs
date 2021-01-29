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
            
            Console.WriteLine("Numero Fatorial: " + CalcularFatorial(5));

            Console.WriteLine("Premio de: " + CalcularPremio(100, "vip", null).ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Premio de: " + CalcularPremio(100, "basic", 3).ToString("F2"), CultureInfo.InvariantCulture);

            Console.WriteLine(ContarPrimos(10));

            Console.WriteLine("Vogais: " + CalcularVogais("Luby Software"));

            Console.WriteLine("Preço com desconto R$:" + CalcularValorComDescontoFormatado("R$ 6.800,00 ", "30%"));

            Console.Write("Diferença em dias: " + CalcularDiferencaData("10122020", "25122020"));

            int[] vetor = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Vetor com Pares:" + ObterElementosPares(vetor));

            string[] vetor1 = new string[] {
                    "John Doe",
                    "Jane Doe",
                    "Alice Jones",
                    "Bobby Louis",
                    "Lisa Romero"
            };

            Console.WriteLine("Nomes Contidos no vetor : " + BuscarPessoa(vetor1, "Doe"));
            Console.WriteLine("Nomes Contidos no vetor : " + BuscarPessoa(vetor1, "Alice"));
            Console.WriteLine("Nomes Contidos no vetor : " + BuscarPessoa(vetor1, "Louis"));

            Console.WriteLine(TransformarEmMatriz("1,2,3,4,5,6"));


            int[] vetor2 = new int[] { 1, 2, 3, 4, 5 };
            int[] vetor3 = new int[] { 1, 2, 5 };
            Console.WriteLine(" Elementos Faltantes: " + ObterElementosFaltantes(vetor2, vetor3));


            int[] vetor4 = new int[] { 1, 4, 5 };
            int[] vetor5 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(" Elementos Faltantes: " + ObterElementosFaltantes(vetor4, vetor5));

            int[] vetor6 = new int[] { 1, 2, 3, 4 };
            int[] vetor7 = new int[] { 2, 3, 4, 5 };

            Console.WriteLine(" Elementos Faltantes: " + ObterElementosFaltantes(vetor6, vetor7));

            int[] vetor8 = new int[] { 1, 3, 4, 5 };
            int[] vetor9 = new int[] { 1, 3, 4, 5 };
           

            Console.WriteLine(" Elementos Faltantes: " + ObterElementosFaltantes(vetor8, vetor9));

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
                        // bool ePrimo = true;  // tirar o comentario para ver a impressao dos primos até  o nume digitado
                        contador++;
                        for (int j = 3; j < i /2; j++)
                        {
                            if(i % j == 0)
                            {
                                //ePrimo = false;  // tirar o comentario para ver a impressao dos primos até  o nume digitado
                                break;
                            }
                        }
                        //if (ePrimo) Console.WriteLine(i);  // tirar o comentario para ver a impressao dos primos até  o nume digitado
                        
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

            int[] pares = par.ToArray();

            // conversao da array de int para string para retornar no console  
            string  strPares = String.Join(", ", pares.Select(p => p.ToString()).ToArray());
            Console.WriteLine();
            return strPares;

        }

        static string BuscarPessoa(string[] vetor, string stringToCheck)
        {
            List<string> nomes = new List<string>();

            foreach (string x in vetor)
            {
                if (stringToCheck.All(x.Contains))
                {
                    nomes.Add(x);
                }
            }

            string[] selcionados = nomes.ToArray();

            string selected = String.Join(",", nomes.Select(p => p.ToString()).ToArray());
            Console.WriteLine();
            return selected;

           
        }


        static int[,] TransformarEmMatriz(string numeros)
        {

            int[] numA = new int[6];

            string par1 = numeros.Substring(0, 3);
            string par2 = numeros.Substring(4, 3);
            string par3 = numeros.Substring(8, 3);


            var array = par1.Split(',');
            var array1 = par2.Split(',');
            var array2 = par3.Split(',');

            int[] myInts = array.Select(int.Parse).ToArray();
            int[] myInts2 = array1.Select(int.Parse).ToArray();
            int[] myInts3 = array2.Select(int.Parse).ToArray();

            int[,] pares = { { myInts[0], myInts[1]}, { myInts2[0], myInts2[1] } , { myInts3[0], myInts3[1] } };

            return pares;
        }

        static string ObterElementosFaltantes(int[] firstArray, int[] secondArray)
        {

            int[] exect = new int[1];
            int[] ops = new int[1];
            string strFalt;

            if(firstArray.Length > secondArray.Length )
            {
                exect = firstArray.Except(secondArray).ToArray();


                // conversao da array de int para string para retornar no console  
                strFalt = String.Join(", ", exect.Select(p => p.ToString()).ToArray());
                Console.WriteLine();
                return strFalt;
            }
            else if (secondArray.Length >  firstArray.Length)
            {
                 exect = secondArray.Except(firstArray).ToArray();
                // conversao da array de int para string para retornar no console  
                strFalt = String.Join(", ", exect.Select(p => p.ToString()).ToArray());
                Console.WriteLine();
                return strFalt;
            }
            else  if (secondArray.Length == firstArray.Length)
            {
                List<int> fal = new List<int>();

                ops = firstArray.Except(secondArray).ToArray();
                exect = secondArray.Except(firstArray).ToArray();

                for (int i = 0; i < exect.Length; i++)
                {
                    fal.Add(ops[0]);
                    fal.Add(exect[0]);
                }

                exect = fal.ToArray();
               
                // conversao da array de int para string para retornar no console  
                strFalt = String.Join(", ", exect.Select(p => p.ToString()).ToArray());
                Console.WriteLine();
                return strFalt;
            }


            // conversao da array de int para string para retornar no console  
            strFalt = String.Join(", ", exect.Select(p => p.ToString()).ToArray());
            Console.WriteLine();
            return strFalt;

            

        }

    }
}
