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

Console.WriteLine($"Nome do Primeiro Time: ");
string nome1 = Console.ReadLine(); 

Console.WriteLine($"Nome do Segundo Time: ");
string nome2 = Console.ReadLine(); 

Console.WriteLine($"Quantos Gols do {nome1}?");
int time1 = int.Parse(Console.ReadLine()); 

Console.WriteLine($"Quantos Gols do {nome2}?");
int time2 = int.Parse(Console.ReadLine()); 

if (time1 > time2) 
{
    Console.WriteLine($"Vitória do {nome1} Com {time1} gols.");
} 
else if (time1 < time2)
{
    Console.WriteLine($"Vitória do {nome2} Com {time2} gols.");
} 
else 
{
    Console.WriteLine($"Empate entre os Dois gigantes, {nome1} e {nome2}");
}
