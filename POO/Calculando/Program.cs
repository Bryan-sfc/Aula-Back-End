checked using System.Diagnostics.Contracts;
using Calculando.Classes;

Calculadora calc = new Calculadora();

Console.WriteLine($"Bem Vindo a calculadora");

Console.Write($"Digite o Primeiro Número: ");
float numero1 = float.Parse(Console.ReadLine()!);

Console.Write($"Digite o Segundo Número: ");
float numero2 = float.Parse(Console.ReadLine()!);

calc.numero1 = numero1;
calc.numero2 = numero2;

Console.WriteLine(@"
Deseja fazer qual Operação?
    1)somar
    2)subtração
    3)Multiplicação
    4)Divisão");
Console.Write($"Opção: ");
string opcao = Console.ReadLine()!;
Console.WriteLine();

if (opcao == "1")
{
    calc.somar();
}
else if (opcao == "2")
{
    calc.subtrair();
}
else if (opcao == "3")
{
    calc.Multiplicar();
}
else
{
    calc.Divisao();
}
