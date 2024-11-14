using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Pessoa
    {
        public string ? Nome;

        public int Idade;

        public int Cpf;

        public float Peso { get; set; }

        public float Altura { get; set; }

        public void Envelhecer(){
            Idade++;
        }

        public void Engordar(float _kg){
            Peso = Peso + _kg;
        }

        public void Emagrecer(float	_kg){
            Peso = Peso - _kg;
        }
    }
}