using RPG;
using RPG.Classes;

Personagem Pers = new Personagem();
Pers.Nome = "";
Pers.Idade = 0;
Pers.Armadura = "";
Pers.IA = "";

Console.Write($"Defina o Nome do seu Personagem: ");
Pers.Nome = Console.ReadLine()!;

Console.Write($"Defina a Idade sua idade, {Pers.Nome}: ");
Pers.Idade = int.Parse(Console.ReadLine()!);

Console.Write($"Defina Qual é sua Armadura? {Pers.Nome}: ");
Pers.Armadura = Console.ReadLine()!;

Console.Write($"Qual o Nome de Sua IA? {Pers.Nome}: ");
Pers.IA = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine(@$"
O que desejas fazer {Pers.Nome}?
1)Partir para a Agressão
2)Ficar na Paz
3)Tomar Uma pitu");
Console.Write($"R: ");
string opcao = Console.ReadLine()!;
Console.WriteLine();


if (opcao == "1")
{
    Pers.Atacar();
}
else if (opcao == "2")
{
    Pers.Defender();
}
else if (opcao == "3")
{
    Pers.RestaurarArmadura();
}
else
{
    Console.WriteLine($"Você Pulou o Desafio!");
}

Console.WriteLine();
Console.WriteLine($"Nome do Seu Personagem: {Pers.Nome}");
Console.WriteLine($"Idade do(a) {Pers.Nome}: {Pers.Idade}");
Console.WriteLine($"Armadura do(a) {Pers.Nome}: {Pers.Armadura}");
Console.WriteLine($"IA do(a) {Pers.Nome}: {Pers.IA}");
Console.WriteLine();
