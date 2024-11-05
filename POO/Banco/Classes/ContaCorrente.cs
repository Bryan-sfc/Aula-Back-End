using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Banco.Classes
{
    public class ContaCorrente
    {
        public int NumeroConta;

        public String? Titular;

        public float saldo;

        public void Depositar(float valor)
        {
            saldo = saldo + valor;
        }

        public void Sacar(float valor)
        {
            saldo = saldo - valor;
        }
    }
}