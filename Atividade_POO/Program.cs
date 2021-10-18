using System;

namespace Atividade_POO
{
    class Program
    {
        class ContaCorrente
        {
            private string _nome;

            public double Saldo { get; set; }

            public int Agencia { get; set; }

            public ContaCorrente() { }

            public ContaCorrente(string nome, int agencia, double saldo)
            {
                _nome = nome;
                Agencia = agencia;
                Saldo = saldo;
            }

            public void Saque(double valor)
            {
                Saldo -= valor;
            }

            public void Deposito(double valor)
            {
                Saldo += valor;
            }

            public String Nome
            {
                get { return _nome; }
                set
                {
                    if(value.Length < 3)
                    {
                        Console.WriteLine("Erro nome inválido");
                    }
                    else
                    {
                        _nome = value;
                    }
                }

            }

        }

        class ContaPoupanca : ContaCorrente
        {

            public double TaxaSelic { get; private set; }
            public double Garantia { get; private set; }

            public ContaPoupanca(String nome, int agencia, double saldo, double garantia)
            {
                Nome = nome;
                Agencia = agencia;
                Saldo = saldo;
                TaxaSelic = 0.0525;
                Garantia = garantia;
            }


            public double Investimento(double valor)
            {
                return this.Saldo += valor;
            }

            public double projecaoRendimento()
            {
                return Saldo *= TaxaSelic;
            }
        }
        
        static void Main(string[] args)
        {
            
            ContaCorrente conta_Maria = new ContaCorrente("Maria", 019, 888.09);
            Console.WriteLine("Nome: " + conta_Maria.Nome);
            Console.WriteLine("Agência: " + conta_Maria.Agencia);
            Console.WriteLine("Saldo: " + conta_Maria.Saldo);

            conta_Maria.Saque(10.20);
            Console.WriteLine("Saque realizado ! Saldo Atual: " + conta_Maria.Saldo);
            conta_Maria.Deposito(30.40);
            Console.WriteLine("Depósito realizado ! Saldo Atual: " + conta_Maria.Saldo);

            ContaPoupanca contaJose = new ContaPoupanca("José", 29, 1098.90, 250000);
            Console.WriteLine("Nome: " + contaJose.Nome);
            Console.WriteLine("Agência: " + contaJose.Agencia);
            Console.WriteLine("Saldo: " + contaJose.Saldo);
            Console.WriteLine("Garantia: " + contaJose.Garantia);

            contaJose.Investimento(871.09);
            Console.WriteLine("Investimento realizado ! Saldo Atual: " + contaJose.Saldo);
            Console.WriteLine("Projeção de ganho" + contaJose.projecaoRendimento());


        }
    }
}
