using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12DepositoRetiradaWhileSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe o saldo na conta: ");
                double saldo = double.Parse(Console.ReadLine());

                while (saldo < 0)
                {
                    Console.WriteLine("O Saldo não pode ser menor que 0 (Zero)");
                    Console.Write("Informe o saldo na conta: ");                    
                    saldo = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("Saldo Atual: " + saldo.ToString("C"));

                int resp = 0;

                while (resp == 0)
                {
                    Console.WriteLine("Escolha uma das opções: " +
                        "\n ( 1 ) - Depósito." +
                        "\n ( 2 ) - Retirada." +
                        "\n ( 3 ) - Encerrar.");
                    int operacao = int.Parse(Console.ReadLine());

                    switch (operacao)
                    {
                        case 1:
                            Console.Write("Escolha o valor a ser depositado: ");
                            saldo += double.Parse(Console.ReadLine());

                            Console.WriteLine("Saldo após depósito: " + saldo.ToString("C"));
                            break;

                        case 2:
                            Console.Write("Escolha o valor a ser retirado: ");
                            double retirada = double.Parse(Console.ReadLine());

                            while (retirada > saldo)
                            {
                                Console.WriteLine("Saldo insuficiente, tente novamente");
                                Console.Write("Escolha o valor a ser retirado: ");
                                retirada = double.Parse(Console.ReadLine());
                            }
                            
                                saldo -= retirada;
                                Console.WriteLine("Saldo após retirada: " + saldo.ToString("C"));
                            
                            break;

                        case 3:
                            Console.WriteLine("Saldo: " + saldo.ToString("C"));
                            Console.WriteLine("Pressione qualquer tecla para encerrar...");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                    }
                    Console.WriteLine("Deseja repetir o processo?");
                    resp = 0;

                }
                
            }
            catch(Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
            finally
            {
                Console.WriteLine("Pressione qualquer tecla para encerrar...");
                Console.ReadKey();
                Environment.Exit(0);
            }

        }
    }
}
