﻿//Importando as classes de dentro da pasta Classes
using ClasseObjeto.Classes;

Console.WriteLine($"");

//Cria o objeto/variável animal
Animal cachorro = new Animal();

cachorro.nome = "Priceso";
cachorro.raca = "Golden";
cachorro.cor = "Dourado";
cachorro.idade = 7;

Console.WriteLine($"Nome do Cachorrino: {cachorro.nome}");
Console.WriteLine($"Idade do {cachorro.nome}: {cachorro.idade}");
Console.WriteLine($"Cor do {cachorro.nome}: {cachorro.cor}");
Console.WriteLine($"Raça do {cachorro.nome}: {cachorro.raca}");

Console.WriteLine($"");

//-------------------------------------------------------------------//
//-------------------------------------------------------------------//
Animal macaco = new Animal();

macaco.nome = "Jorge";
macaco.raca = "Mico-Leão-Dourado";
macaco.cor = "Dourado";
macaco.idade = 3;

Console.WriteLine($"Nome do Macaco: {macaco.nome}");
Console.WriteLine($"Idade do {macaco.nome}: {macaco.idade}");
Console.WriteLine($"Cor do {macaco.nome}: {macaco.cor}");
Console.WriteLine($"Raça do {macaco.nome}: {macaco.raca}");

Console.WriteLine($"");

//-------------------------------------------------------------------//
//-------------------------------------------------------------------//
Animal peixe = new Animal();

peixe.nome = "João";
peixe.raca = "Baiacu";
peixe.cor = "Amarelo";
peixe.idade = 1;

Console.WriteLine($"Nome do peixe: {peixe.nome}");
Console.WriteLine($"Idade do {peixe.nome}: {peixe.idade}");
Console.WriteLine($"Cor do {peixe.nome}: {peixe.cor}");
Console.WriteLine($"Raça do {peixe.nome}: {peixe.raca}");

Console.WriteLine($"");
//-------------------------------------------------------------------//
//-------------------------------------------------------------------//

cachorro.FazerBarulho("Au Au!");
Console.WriteLine($"Idade de {cachorro.nome} é {cachorro.idade}");
cachorro.Envlhecer();
Console.WriteLine($"Nova idade de {cachorro.nome} agora é {cachorro.idade}");
Console.WriteLine($"");

macaco.FazerBarulho("Uh Uh Ah Ah");
Console.WriteLine($"Idade de {macaco.nome} agora é {macaco.idade}");
Console.WriteLine($"");

peixe.FazerBarulho("Blop Blop");
Console.WriteLine($"Idade de {peixe.nome} agora é {peixe.idade}");
Console.WriteLine($"");
