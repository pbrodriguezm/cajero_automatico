using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajeros
{
    class Cuenta
    {
        double saldo;
        String numCuenta;
        char moneda;

        public Cuenta(double saldo, string numCuenta, char moneda)
        {
            this.saldo = saldo;
            this.numCuenta = numCuenta;
            this.moneda = moneda;
        }

        public double Saldo { get => saldo; set => saldo = value; }
        public string NumCuenta { get => numCuenta; set => numCuenta = value; }
        public char Moneda { get => moneda; set => moneda = value; }
    }
}
