using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Method
{
    public class ContaBancaria
    {
        public int NumeroConta { get; set; }

        public int NumeroAgencia { get; set; }

        private decimal _saldo { get; set; }

        public void Transferir(decimal valor, ContaBancaria contaDestino)
        {
            if (_saldo >= valor)
            {
                _saldo -= valor;
                contaDestino._saldo += valor;
            }
        }

        public void Receber(decimal valor)
        {
            _saldo += valor;
        }

        public void ImprimaInformacoesDaConta()
        {
            ImprimaDetalhesDaConta();
            ImprimaSaldo();
        }

        private void ImprimaDetalhesDaConta()
        {
            Console.WriteLine("Número da Conta: " + NumeroConta);
            Console.WriteLine("Agência: " + NumeroAgencia);
        }

        private void ImprimaSaldo()
        {
            Console.WriteLine("O saldo da conta é: " + _saldo);
        }
    }
}
