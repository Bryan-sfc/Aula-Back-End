using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Pilares
{
    public class ContaCorrente : Conta
    {
        public float Limite { get; set; }

        public bool Tranferir(float valor, Conta ContaDestino)
        {
            return false;
        }
        
        public override bool Depositar(float valor)
        {
            if (valor > 0)
            {
                Saldo = Saldo + valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override float Sacar(float valor)
        {
            if (valor <= Saldo)
            {
                Saldo = Saldo - valor;
                return valor;
            }
            else
            {
                Console.WriteLine($"Saldo Insulficiente.");
                return 0;
            }
        }

    }
}