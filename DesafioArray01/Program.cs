int[] numeros = new int[6];
int par = 0;
int impar = 0;

for (int i = 0; i < 6; i++){
    Console.WriteLine($"Digite um Numero inteiro Positivo: ");
    numeros[i] = int.Parse(Console.ReadLine());


    if (numeros[1] % 2 == 0){
        par++;
    }
    else{
        impar++;
    }
}

Console.WriteLine($"Quantidade total de numeros pares: {par}");
Console.WriteLine($"Quantidade total de numeros impares: {impar}");
