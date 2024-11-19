//Subclasse - Herda Personagem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Arqueiro : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"O Arqueiro Usa Seu Arco! Olha A Cabeçaa! ");

        }
    }
}