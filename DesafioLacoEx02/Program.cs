// DesafioLaco02: Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
// Total de Homens;
// Total de Mulheres;
// Média de idade dos Homens;
// Média de idade das mulheres.

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
|██     ▀▀▀                  █ ▄█    ▀▀█▄|
|██                     █    ██▀     ▄▄██|
|██                     █    █       ▀▀█▄|
|██                    █     █       ▄▄██|
| ██                  ▄▀     █       ▀▀█▄|
| ▀█      █         ▄█▀      █       ▄▄██|
| ▄██▄     ▀▀▀▄▄▄▄▀▀         █       ▀▀█▄|
|  ▀▀▀▀                      █▄▄▄▄▄▄▄▄▄██|
+~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+");

int homens = 0;
int mulheres = 0;
int idadeHomem = 0;
int idadeMulher = 0;

for(int i = 1; i <=4; i++)
{
    Console.WriteLine($"Você é homem ou mulher? m/f");
    string genero = Console.ReadLine();
    
    Console.WriteLine($"Qual sua idade?");
    int idade = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (genero == "m")
    {
        homens ++;
        idadeHomem+=idade;
    }
    else 
    {
        mulheres ++;
        idadeMulher+=idade;
    }
}
float midiaHomem = (idadeHomem / homens);
float midiaMulher = (idadeMulher / mulheres);


Console.WriteLine($"Total de homens {homens}");
Console.WriteLine($"Total de Mulheres {mulheres}");
Console.WriteLine($"Media de idade dos homens {midiaHomem}");
Console.WriteLine($"Media de idade das mulheres {midiaMulher}");
