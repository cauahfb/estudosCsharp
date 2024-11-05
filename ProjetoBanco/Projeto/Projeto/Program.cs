using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Seja bem vindo ao Banco Bruno Cesar");
            Thread.Sleep(2500);
            Console.WriteLine("Carregando sistema");
            for (int i = 0; i < 35; i++)
            {
                Console.Write(".");
                Thread.Sleep(150);
            }
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("Vi que é a primeira vez que você está acessando, vamos criar sua conta.");
            Thread.Sleep(2500);
            Console.WriteLine("Lembre-se o número da conta deve conter 4 dígitos.");
            Console.Write("Entre com o número da conta: ");
            string NumeroConta = Console.ReadLine();
            Console.Write("Entre com o titular da conta: ");
            string NomeTitular = Console.ReadLine();

            ContaBancaria contaBancaria = new ContaBancaria(NumeroConta, NomeTitular);

            Console.Write("Haverá depósito inicial ? (S/N) ");
            string DepositoInicial = Console.ReadLine();

            while (DepositoInicial != "S" && DepositoInicial != "N")
                {
                Console.WriteLine("Entrada Inválida, tente novamente");
                Console.Write("Haverá depósito inicial ? (S/N) ");
                DepositoInicial = Console.ReadLine();
            }

            Console.WriteLine();

            if (DepositoInicial == "S")
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                contaBancaria.Saldo = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria.ToString());

            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            contaBancaria.DepositarDinheiro(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria.ToString());
            Console.WriteLine();

            Console.WriteLine("* O Banco Bruno Cesar cobra $ 5 por saque. - Clientes VIP são isentos.");
            Console.Write("Entre com um valor para saque: ");
            contaBancaria.SacarDinheiro(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria.ToString());
            Console.WriteLine();

        }
    }
}