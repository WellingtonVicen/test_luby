using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio.Entities;
using System.Globalization;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Estoque estoque = new Estoque(10, 5, 0.0f);
        
  
            for (; ; )
            {
                Console.WriteLine("Bem vindo a Vending Machine");
                Console.WriteLine("--------------------------------");
                Console.WriteLine();

                Console.WriteLine("1- exibir Estoque");
                Console.WriteLine("2- Comprar");
                Console.WriteLine(" Total de Vendas = R$" + estoque.TotalDeVendas.ToString("f2"),CultureInfo.InvariantCulture);

                Console.WriteLine();
                Console.Write("Digite um Numero:");
                int opcao = int.Parse(Console.ReadLine());

                if(opcao == 1)
                {
                    Console.WriteLine(estoque);
                    Console.ReadLine();
                }
                else if(opcao == 2)
                {
                    Console.WriteLine("Bebidas Disponiveis: AGUA, REFRIGERANTE ");
                    Console.Write("Digite Sua Opção de Bebida: ");
                    string sele = Console.ReadLine();
                    Console.WriteLine(estoque);
                    Console.WriteLine();

                    Console.Write("Digite a Quantidade Desejada: ");
                    int quantity = int.Parse(Console.ReadLine());

                    estoque.ControleEstoque(quantity, sele);
                    //estoque.Compra(quantity, agua.Preco);
                   

                    Console.WriteLine(estoque);
                    Console.WriteLine();
                }
               
            }

            
            
        }
    }
}
