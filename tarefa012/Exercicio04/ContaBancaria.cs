using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }

        public ContaBancaria(double saldo)
        {
            this.Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
