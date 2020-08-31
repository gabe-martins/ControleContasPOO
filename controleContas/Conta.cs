using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    public class Conta
    {
        protected long Numero { get; private set; }
        protected decimal Saldo { get; private set; }

        protected Cliente Titular { get; set; }

        protected Conta(long numero, decimal saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }
    }
}
