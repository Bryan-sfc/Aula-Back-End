//Subclasse - Herda Personagem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Guerreiro : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"O Guerreiro Saca Sua Espada! UIÓÓ!");
        }
    }
}