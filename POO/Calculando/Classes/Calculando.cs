using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Calculando.Classes
{
    public class Calculadora
    {
        public float numero1, numero2;

        public void somar()
        {
            float Resultado = numero1 + numero2;
            Console.WriteLine($"Resultado da Soma: {Resultado}");
        }

        public void subtrair()
        {
            float Resultado = numero1 - numero2;
            Console.WriteLine($"Resultado da Subtração: {Resultado}");
        }

        public void Multiplicar()
        {
            float Resultado = numero1 * numero2;
            Console.WriteLine($"Resultado da Multiplicação: {Resultado}");
        }

        public void Divisao()
        {
            float Resultado = numero1 / numero2;
            Console.WriteLine($"Resultado da Divisão: {Resultado}");
        }
    }
}