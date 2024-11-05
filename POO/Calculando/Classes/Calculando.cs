using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Calculando.Classes
{
    public class Calculando
    {
        float numero1;

        float numero2;

        public void somar(float valor)
        {
            valor = numero1 + numero2;
            Console.WriteLine($"Resultado da Soma: {valor}");
        }

        public void subtrair(float valor)
        {
            valor = numero1 - numero2;
            Console.WriteLine($"Resultado da Subtração: {valor}");
        }

        public void Multiplicar(float valor)
        {
            valor = numero1 * numero2;
            Console.WriteLine($"Resultado da Multiplicação: {valor}");
        }

        public void Divisao(float valor)
        {
            valor = numero1 / numero2;
            Console.WriteLine($"Resultado da Divisão: {valor}");
        }
    }
}