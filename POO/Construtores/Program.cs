using System.Collections;
using System.Diagnostics.CodeAnalysis;
using Construtores.Classes;

aluno2 Bryan = new aluno2("Bryan");

aluno2 Larissa = new aluno2("Larissa");
Larissa.CPF = 101223;

aluno2 Eduardo = new aluno2();

aluno2 marconne = new aluno2("Marcone", 1109);

Console.WriteLine(Bryan.Nome);
Console.WriteLine(Bryan.CPF);
Console.WriteLine();

Console.WriteLine(Larissa.Nome);
Console.WriteLine(Larissa.CPF);
Console.WriteLine();

Console.WriteLine(marconne.Nome);
Console.WriteLine(marconne.CPF);
Console.WriteLine();





// List<Jogo> EstoqueJogos = new List<Jogo>();

// Veiculo carro1 = new Veiculo("Ford", "Ka", 2000, "Vermelho");
// Veiculo carro2 = new Veiculo("Chevrollet", "Monza", 1998, "Preto");

// Aluno Aluno1 = new Aluno("Bryan", 16, "Desenvolvimento de Sistemas", "Integral");
// Aluno aluno2 = new Aluno("Lari", 16, "Humanas", "Integral");

// Jogo Jogo1 = new Jogo("GTA 6", 2026, "Ação -  Mundo Aberto", 458.89f);
// Jogo Jogo2 = new Jogo("Angry Birds 7", 2026, "RPG", 100.99f);
// Jogo Jogo3 = new Jogo("Pou 2", 2028, "RPG", 400f);
// Jogo Jogo4 = new Jogo("Free Fire 2", 2026, "RPG", 200f);

// Console.WriteLine();

// EstoqueJogos.Add(Jogo1);
// EstoqueJogos.Add(Jogo2);
// EstoqueJogos.Add(Jogo3);
// EstoqueJogos.Add(Jogo4);

// Console.WriteLine($"<Estoque>");
// foreach (var Jogo in EstoqueJogos)
// {
//     Jogo.ExibirJogo();
//     Console.WriteLine(); 
// }

// Console.WriteLine($"      >>>>Carros Cadastrados<<<<");
// carro1.ExibirDados();
// carro2.ExibirDados();
// Console.WriteLine();

// Console.WriteLine($"      >>>>Alunos Cadastrados<<<<");
// Aluno1.ExibirAluno();
// aluno2.ExibirAluno();
// Console.WriteLine();

// Console.WriteLine($"      >>>>Jogos Cadastrados<<<<");
// Jogo1.ExibirJogo();
// Jogo2.ExibirJogo();
// Console.WriteLine();