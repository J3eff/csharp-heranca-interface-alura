
namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        // 0 - funcionário
        // 1 - diretor
        // 2 - designer
        // N - ....
        private int _tipo;


        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }

        public double GetBonificacao()
        {
            if (_tipo == 1)
                return Salario;

            return Salario * 0.10;
        }
    }
}
