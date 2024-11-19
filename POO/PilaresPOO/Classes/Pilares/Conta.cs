using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Pilares
{
    public abstract class Conta
    {
        public string? Titular { get; set; }

        protected float Saldo { get; set; }

        public abstract float Sacar(float valor);

        public abstract bool Depositar(float valor);

        public float GetSaldo()
        {
            return Saldo;
        }
    }
}