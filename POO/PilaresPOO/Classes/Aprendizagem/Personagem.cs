using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Personagem
    {
        public virtual void Atacar()
        {
            Console.WriteLine("O personagem Esta Atacando!");
        }
    }
}