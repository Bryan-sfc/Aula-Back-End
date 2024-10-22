// Criar cabeçalho de boas vindas
//Pedir dados de cadastro
//Nome
//DtNascimento
//Email
//Telefone
//CPF
//Endereço
//idade - calcular baseado na data de nascimento
//Estado civil

// variáveis e tipos de dados
using System.Runtime.CompilerServices;

Console.WriteLine(@"
+~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+
|               Boas-Vindas              |
+~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+
|       ▄▄▀▀▀▀▀▀▀▀▀▀▄▄█▄    ▄    █       |
|      █▀             ▀▀█▄   ▀         ▄ |
|    ▄▀                 ▀██   ▄▀▀▀▄▄  ▀  |
|  ▄█▀▄█▀▀▀▀▄     ▄▀▀█▄  ▀█▄  █▄   ▀█    |
| ▄█ ▄▀  ▄▄▄ █   ▄▀▄█▄ ▀█  █▄  ▀█    █   |
|▄█  █   ▀▀▀ █  ▄█ ▀▀▀  █   █▄  █    █   |
|██   ▀▄   ▄█▀   ▀▄▄▄▄▄█▀   ▀█  █▄   █   |
|██     ▀▀▀                  █ ▄█    █   |
|██                     █    ██▀    █▄   |
|██                     █    █       ▀▀█▄|
|██                    █     █       ▄▄██|
| ██                  ▄▀     █       ▀▀█▄|
| ▀█      █         ▄█▀      █       ▄▄██|
| ▄██▄     ▀▀▀▄▄▄▄▀▀         █       ▀▀█▄|
|  ▀▀▀▀                      █▄▄▄▄▄▄▄▄▄██|
+~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+");

Console.WriteLine($"Olá, digite seu nome: ");
string Nome = Console.ReadLine()!;

Console.WriteLine($"Olá, {Nome} digite seu Sobrenome: ");
string Sobrenome = Console.ReadLine()!;

Console.WriteLine($"Digite seu ano de nascimento: ");
int DtNascimento = int.Parse(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - DtNascimento;

Console.WriteLine($"Digite seu Email: ");
string Email = Console.ReadLine()!;

Console.WriteLine($"Digite seu telefone: ");
UInt128 Telefone = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite seu CPF: ");
UInt128 CPF = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite seu endereço: ");
string Endereço = Console.ReadLine()!;

Console.WriteLine($"Estado civil: ");
string Estadocivil = Console.ReadLine()!;

// Mostrar dados completos
Console.Clear();

Console.WriteLine(@$"

+~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+
|              Obrigado            |
 >~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~<
| 01 Nome: {Nome}
| 02 Sobrenome: {Sobrenome}
| 03 Idade: {idade}
| 04 Email: {Email}
| 05 Telefone: {Telefone}
| 06 CPF: {CPF}
| 07 Endereço: {Endereço}
| 08 Estadi Civil: {Estadocivil}
+----------------------------------+");

// Estrutura condicionais
// Laços de repetição
// Array
