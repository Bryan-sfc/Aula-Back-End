// DesafioLaco 01: Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// O número de pessoas que responderam SIM;
// O número de pessoas que responderam NÃO;
// O número de mulheres que responderam SIM;
// A porcentagem de homens que responderam NÃO entre todos os homens analisados

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
int produto = 0;
int produtosim = 0;
int homemsim = 0;
int homemnao = 0;
int mulhersim = 0;
int mulhernao = 0;

for(int i = 1; i <=10; i++)
{
    Console.WriteLine($"Qual seu genero? m/f");
    string genero = Console.ReadLine();
    
    Console.WriteLine($"Você aprovou o produto? s/n");
    string produtoRate = Console.ReadLine();
    Console.WriteLine();
    
    if (genero == "m") {
        homens++;
    } else {
        mulheres++;
    }

    if (produtoRate == "s"){
        produtosim++;
    }

    if (genero == "m" && produtoRate == "s"){
        homemsim++;
    } 
    else if (genero == "m" && produtoRate == "n"){
        homemnao++;
    } else if (genero == "f" && produtoRate == "s") {
        mulhersim++;
    } else {
        mulhernao++;
    }
}
int total = (homens + mulheres);
int totalEntrevistadosSim = (homemsim + mulhersim);
int totalEntrevistadosNao = (homemnao + mulhernao);
float percentualHomemNao = (100 / homens) * homemnao;

Console.WriteLine($"Número de pessoas que disseram SIM: {totalEntrevistadosSim}");
Console.WriteLine($"Número de pessoas que disseram NÃO: {totalEntrevistadosNao}");
Console.WriteLine($"Número de mulheres que disseram SIM: {mulhersim}");
Console.WriteLine($"Percentual de homens que disseram não: {percentualHomemNao}%");