using System;

namespace AvaliacaoFinal
{
    class Program
    {
        class Funcionario
        {
            private string _nome;

            public int CargaHoraria { get; set; }

            public double ValorHora { get; set; }

            public Funcionario() { }

            public String Nome
            {
                get { return _nome; }
                set
                {
                    if (value.Length < 3)
                    {
                        Console.WriteLine("Erro nome inválido");
                    }
                    else
                    {
                        _nome = value;
                    }
                }
            }

            public Funcionario(string nome, int cargaHoraria, double valorHora)
            {
                Nome = nome;
                CargaHoraria = cargaHoraria;
                ValorHora = valorHora;
            }

            public virtual double CalculaSalario()
            {
                return ValorHora * CargaHoraria;
            }

            public virtual void ImprimeDados()
            {
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("Salário " + CalculaSalario());
            }
        }

        class FuncionarioTerceiro : Funcionario
        {
            String EmpresaOrigem { get; set; }
            double TaxaServico { get; set; }

            public FuncionarioTerceiro() { }

            public FuncionarioTerceiro(string nome, int cargaHoraria, double valorHora, string empresaOrigem, double taxaServico)
                : base(nome, cargaHoraria, valorHora)
            {
                Nome = nome;
                CargaHoraria = cargaHoraria;
                ValorHora = valorHora;
                EmpresaOrigem = empresaOrigem;
                TaxaServico = taxaServico;
            }

            public override double CalculaSalario()
            {
                double taxaFinal = (ValorHora * CargaHoraria) * TaxaServico;
                return base.CalculaSalario() + taxaFinal;
            }

            public override void ImprimeDados()
            {
                Console.WriteLine("Empresa de Origem: " + EmpresaOrigem);
                base.ImprimeDados();
            }
        }

        static void Main(string[] args)
        {
            String nome = "Cesar Augusto";
            String empresaOrigem = "Banco Itaú";
            int cargaHoraria = 08;
            double valorHora = 30.00;
            double taxaServico = 0.08;

            Console.WriteLine("Digite F para Funcionário ou digite T para Terceiro");
            String tipo = Console.ReadLine();

            if (String.Equals(tipo, "F"))
            {
                Funcionario funcionario = new Funcionario(nome, cargaHoraria, valorHora);
                funcionario.ImprimeDados();

            }
            else if (String.Equals(tipo, "T"))
            {
                FuncionarioTerceiro funcionario = new FuncionarioTerceiro(nome, cargaHoraria, valorHora, empresaOrigem, taxaServico);
                funcionario.ImprimeDados();

            }

        }
    }
}
