using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioJogo.Classes
{
    public class Jogos
    {
        public string Nome;

        public int Lancamento;

        public string Genero;

        public float Preco;

        public void op(){
            Console.WriteLine($"Carregando...");
            
            Thread.Sleep(3000);

            Console.WriteLine($"Opção Validada!");
        }

        public Jogos(string no, int la, string ge, float pc)
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