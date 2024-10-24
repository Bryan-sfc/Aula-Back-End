string[] carros = new string[3];

for (int i = 0; i <= 2; i++)
{
    Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
    carros[i] = Console.ReadLine();
}

for (int i = 0; i <= 2; i++){
    Console.WriteLine($"Carros cadastrados: {carros[i]}");
}


