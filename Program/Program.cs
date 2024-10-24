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

int homem = 0;
int mulher = 0;
int sport = 0;
int sportnao = 0;
int entrevistados = 0;

Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int pessoas = int.Parse(Console.ReadLine()!);


for (int n = 1; n <= pessoas; n++)
{
    Console.WriteLine("Informe seu sexo m/f");
    string sexo = Console.ReadLine()!;
    Console.WriteLine();

    Console.WriteLine("voce gosta de esportes s/n?");
    string esporte = Console.ReadLine()!;
    Console.WriteLine();

    if (sexo == "m")
    {
        homem++;
    }
    else
    {
        mulher++;
    }

    if (esporte == "s")
    {
        sport++;
    } else {
        sportnao++;
    }
}
int qtdEntrevistado = (homem + mulher);

float percentual = (100 / qtdEntrevistado) * sport;
 
Console.WriteLine($"A quantidade de homens: {homem}");
Console.WriteLine($"A quantidade de mulheres: {mulher}");
Console.WriteLine($"A quantidade de pessoas que gostam de esportes: {sport}");
Console.WriteLine($"A quantidade de pessoas que não gostam de esportes: {sportnao}");
Console.WriteLine($"A quantidade de entrevistados: {qtdEntrevistado}");
Console.WriteLine($"Percentual de pessoas que não gostam de esportes: {percentual}%");