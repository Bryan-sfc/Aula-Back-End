//Importando as classes de dentro da pasta Classes
using AtividadeClasses.Classes;

Console.WriteLine("");

Carros carrinho = new Carros();

Console.Write($"A Marca do Carro: ");
carrinho.Marca = Console.ReadLine();

Console.Write($"O Modelo do Carro: ");
carrinho.Modelo = Console.ReadLine();

Console.Write($"A Cor do Carro: ");
carrinho.Cor = Console.ReadLine();

Console.Write($"A Potência do Carro: ");
carrinho.Potencia = int.Parse(Console.ReadLine());

Console.Write($"A Quantidade de Portas do Carro: ");
carrinho.QtdPortas = int.Parse(Console.ReadLine());
Console.WriteLine("");

carrinho.Ligar();

Console.WriteLine($"Modelo do {carrinho.Modelo}");
Console.WriteLine($"Marca do Carro {carrinho.Modelo}: {carrinho.Marca}");
Console.WriteLine($"Cor do {carrinho.Modelo}: {carrinho.Cor}");
Console.WriteLine($"Potência do {carrinho.Modelo}: {carrinho.Potencia}");
Console.WriteLine($"Quntidade de Portas do {carrinho.Modelo}: {carrinho.QtdPortas}");