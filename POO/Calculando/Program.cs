using System.Diagnostics.Contracts;
using Calculando.Classes;

Calculando resultado = new Calculando();

Console.WriteLine($"Bem Vindo a calculadora");

Console.Write($"Digite o Primeiro Número: ");
float numero1 = float.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.Write($"Digite o Primeiro Número: ");
float numero2 = float.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.WriteLine(@"
Deseja fazer qual Operação?
    1)somar
    2)subtração
    3)Multiplicação
    4)Divisão");
string opcao = Console.ReadLine()!;

if (opcao == "1")
{
    Console.WriteLine($"{somar}");
}
else if (opcao == "2")
{
    Console.WriteLine($"{subtrair}");
}
else if (opcao == "3")
{
    Console.WriteLine($"{Multiplicar}");
}
else
{
    Console.WriteLine($"{Divisao}");
}
