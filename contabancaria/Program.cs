using System;

namespace SistemadeBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n)");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Digite o depósito inicial: ");
                float depositoinicial = float.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoinicial);
            }
            else
            {
                conta = new ContaBancaria(titular, numero);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Digite o valor a ser depositado: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.WriteLine("Digite o valor a ser sacado: ");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);

        }

    }
}

