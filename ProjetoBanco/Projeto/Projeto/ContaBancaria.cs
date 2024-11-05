using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class ContaBancaria
    {
        private string _numero;
        private double _saldo;
        public string Nome;

        public ContaBancaria(string numero, string nome)
        {
            Numero = numero; 
            Nome = nome;
        } 

        public string Numero
        {
            get { return _numero; }
            set
            {
                if (value.Length == 4)
                {
                    _numero = value;
                }
                else
                {
                    Console.WriteLine("Número digitado inválido, tente novamente");
                    DefinirNumero();

                }
            }
        }

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                {  _saldo = value; }
            }
        }

        public void DepositarDinheiro(double saldo)
        {
            
            _saldo += saldo;
        }

        public void SacarDinheiro(double saldo)
        {
            if (saldo > 0)
            {
                _saldo -= (saldo + 5);
            }
        }

        public void DefinirNumero()
        {
            while (true)
            {
                Console.Write("Entre com o número da conta: ");
                string NumeroDaConta = Console.ReadLine();
                if (NumeroDaConta.Length == 4)
                {
                    Numero = NumeroDaConta;
                    break;
                }
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }
        }

        public override string ToString()
        {
            return "Conta: " 
                + Numero 
                + ", Titular: " 
                + Nome + ", Saldo: $ " 
                + Saldo.ToString("F2");
        }
    }
}
