using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();            

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "546.897.157-20";
            carlos.Salario = 2000;
            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.148-3";
            roberta.Salario = 5000;
            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine("Funcionario - Bonificação: " + carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine("Diretor - Bonificação: " + roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
