using DesafioJogo;
using DesafioJogo.Classes;

Jogos Game = new Jogos();

do{

    Console.WriteLine(@$"-Menu de Opções:
    1) Cadastrar Jogo
    2) Listar Jogos
    0) Sair
    ");
Console.Write($"R:");
int op = int.Parse(Console.ReadLine()!);

Game.op();

if (op == 1)
{
    Console.WriteLine($"Você Escolheu Cadastrar Um Jogo!");
    
} else if (op == 2)
{
    Console.WriteLine($"Você Escolheu Listar Todos os jogos!");
    
} else {
    Console.WriteLine($"Escolha Uma Opção Válida.");  
}



}while (op >= 1);
Console.WriteLine($"Você Saiu do Aplicativo");
