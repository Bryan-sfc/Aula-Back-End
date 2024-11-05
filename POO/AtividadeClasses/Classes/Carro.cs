using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeClasses.Classes
{
    public class Carros
    {
        public string Marca;
        public string Modelo;
        public string Cor;
        public int Potencia;
        public int QtdPortas;

        public void Acelerar()
        {
            Console.WriteLine($"O {Modelo} está acelerando: Vrum vrum!");
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando o {Modelo} ");
        }

        public void Desligar()
        {
            Console.WriteLine($"{Modelo} desligado");
        }

        public void Freiar()
        {
            Console.WriteLine($"{Modelo}  Freiando: ");
        }
    }z
}