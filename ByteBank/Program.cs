using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();            

            Funcionario carlos = new Funcionario(2000, "546.897.157-20");
            carlos.Nome = "Carlos";          
            gerenciador.Registrar(carlos);

            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do carlos " + carlos.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Diretor roberta = new Diretor(5000, "454.658.148-3");
            roberta.Nome = "Roberta";

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario robertaTest = roberta;

            roberta.AumentarSalario();
            Console.WriteLine("Novo salário do roberta " + roberta.Salario);


            Console.WriteLine("Bonificação de uma referencia de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia de Funcionario: " + robertaTest.GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
