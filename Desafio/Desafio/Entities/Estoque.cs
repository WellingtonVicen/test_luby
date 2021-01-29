using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Desafio.Entities
{
    class Estoque
    {
        public int QtdEmEstoqueA { get; set; }
        public int QtdEmEstoqueR { get; set; }
        public string TipodeBebida { get; set; }

        public double TotalDeVendas { get; set; }

        public Agua Agua { get; set; }

        public Refrigerante Refrigerante { get; set;  }


        public Estoque() { }

        public Estoque(int qtdEmEstoqueA, int qtdEmEstoqueR, float totaldeVendas)
        {
            QtdEmEstoqueA = qtdEmEstoqueA;
            QtdEmEstoqueR = qtdEmEstoqueR;
            TotalDeVendas = totaldeVendas;
        }

        public  void ControleEstoque(int quantity, string tipobebida)
        {
            if(tipobebida == "AGUA" || tipobebida ==  "agua")
            {
                if(quantity <= QtdEmEstoqueA)
                {
                    Agua agua = new Agua(2.50f);
                    Compra(quantity, agua.Preco);
                   QtdEmEstoqueA =   QtdEmEstoqueA - quantity;
                } 
                else
                {
                    Console.WriteLine("Não Temos a Quantidade que deseja Disponivel");
                    
                }

            }
            else if (tipobebida == "REFRIGERANTE" || tipobebida == "refrigerante")
            {

                if(quantity <= QtdEmEstoqueR)
                {
                    Refrigerante refrigerante = new Refrigerante(5.0f);
                    Compra(quantity, refrigerante.Preco);
                    QtdEmEstoqueR = QtdEmEstoqueR - quantity;
                }
                else
                {
                    Console.WriteLine("Não Temos a Quantidade que deseja Disponivel");
                }

            }
        }

        public void Compra(int quantity, float preco) 
        {
            float total = quantity * preco;
            Console.WriteLine("Valor a Pagar R$: " + total.ToString());
            Console.Write("Digite o Valor do Deposito R$: ");
            float valorinserido = Single.Parse(Console.ReadLine());

            if (valorinserido < total)
            {

                while (valorinserido < total)
                {
                    float faltante = total - valorinserido;
                    Console.WriteLine("Insira o Valor Restante para finalizar a Compra R$: " + faltante.ToString());
                    float restante = Single.Parse(Console.ReadLine());
                    valorinserido += restante;

                    Console.WriteLine();

                    if (valorinserido == total)
                    {

                        Console.WriteLine("Compra Concluida!! Volte Sempre");
                        this.TotalDeVendas += total;
                        Console.WriteLine();
                    }
                }

                
            }
            else if (valorinserido == total)
            {
                this.TotalDeVendas += total;
                Console.WriteLine("Compra Concluida Volte Sempre");
                Console.WriteLine();
            }
            else if (valorinserido > total)
            {
                float troco = valorinserido - total;
                Console.WriteLine("Seu Troco é  R$: " + troco.ToString());
                Console.WriteLine("Compra Concluida!! Volte Sempre");
                this.TotalDeVendas += total;
                Console.WriteLine();

            }


        }

       
 

        


        public override string ToString()
        {
            return "QTD Refrigerantes: "
                + QtdEmEstoqueR.ToString()
                + ", Valor "
                + "R$: 5,00"
                + "\nQTD Agua: "
                + QtdEmEstoqueA.ToString()
                + " ,Valor: "
                + "R$:2,50";
        }
    }
}
