using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Veiculos
    {
        public String? Marca { get; set; }

        public String? Modelo { get; set; }

        public string? Cor { get; set; }

        public int Potencia { get; set; }

        public int QtdPassageiros { get; set; }

        public void Ligar()
        {
            Console.WriteLine($"Veiculo Ligando!");
        }

        public void Desligar()
        {
            Console.WriteLine($"Veiculo Desligando!");
        }

        public void Buzinar()
        {
            Console.WriteLine($"O Veiculo Buzinou!");
        }
    }
}