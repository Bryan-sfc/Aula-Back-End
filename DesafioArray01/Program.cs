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

int[] numeros = new int[6];
int impar = 0;
int par = 0;

for (int i = 0; i < 6; i++)
{

   Console.WriteLine($"Digite um numero inteiro:");
   numeros[i] = int.Parse(Console.ReadLine()!);

   if (numeros[i] % 2 == 0)
   {
      par++;
   }
   else
   {
      impar++;
   }

}
Console.WriteLine();


Console.WriteLine($"Numeros pares: {par} ");
for (var i = 0; i < numeros.Length; i++)
{
   if (numeros[i] % 2 == 0)
   {
      Console.Write($"{numeros[i]}");
   }
}

Console.WriteLine();

Console.WriteLine($"Numeros impares: {impar}");
for (var i = 0; i < numeros.Length; i++)
{
   if (numeros[i] % 2 != 0)
   {
      Console.Write($"{numeros[i]}");
   }
}