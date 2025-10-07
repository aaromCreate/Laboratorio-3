using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Cuenta
    {
        private double saldo;
        public void retirar(double monto)
        {
            saldo= saldo-monto;
        }
        public void  depositar(double monto)
        {
            saldo= saldo+monto;
        }
        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public double getSaldo()
        {
            return saldo;
        }

    }
}
