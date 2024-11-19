//Subclasse - Herda Personagem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Mago : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"O Mago Lança Seu Feitiço! FireBall!");
        }
    }
}