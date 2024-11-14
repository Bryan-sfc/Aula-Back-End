using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class aluno2
    {
        public string Nome;

        public int CPF;

        public int Idade;

        public string Curso;

        public aluno2 ( ) { }

        public aluno2(string _chuchu)
        {
            Nome = _chuchu;
        }

        public aluno2(string _nome, int _cpf){
            Nome = _nome;
            CPF = _cpf;
        }

         public void ExibirAluno()
        {
            Console.WriteLine(@$"
            Nome: {Nome}
            Idade: {Idade}
            Curso: {Curso}
            CPF:{CPF}");
        }
    }
}