using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class Personagem
    {
        public string? Nome;

        public int Idade;

        public string? Armadura;

        public string? IA;

        public void Atacar()
        {
            Console.WriteLine($"O personagem {Nome} Atacou aquele Incapaz!");
        }

        public void Defender()
        {
            Console.WriteLine($"O personagem {Nome} quase se Lascou!");
        }

        public void RestaurarArmadura()
        {
            Console.WriteLine($"A sua IA,{IA}: Resturou sua Armadura {Nome}!");
        }
    }
}