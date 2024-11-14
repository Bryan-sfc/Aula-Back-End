using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
        public string Nome;

        public int Lancamento;

        public string Genero;

        public float Preco;

        public Jogo(string no, int la, string ge, float pc)
        {
            Nome = no;
            Lancamento = la;
            Genero = ge;
            Preco = pc;

            Console.WriteLine($">>>>Jogo Cadastrado<<<<");
        }

        public void ExibirJogo()
        {
            Console.WriteLine(@$"
            Nome: {Nome}
            Lançamento: {Lancamento}
            Gênero: {Genero}
            preço: {Preco}");
        }
    }
}