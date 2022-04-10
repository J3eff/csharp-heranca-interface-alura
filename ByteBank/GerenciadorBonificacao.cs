using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(double funcionario)
        {
            //_totalBonificacao += funcionario.GetBonificacao();
            return funcionario;
        }

        public void Registrar(double diretor)
        {
            //_totalBonificacao += diretor.GetBonificacao();
            return diretor;
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }


    }
}
