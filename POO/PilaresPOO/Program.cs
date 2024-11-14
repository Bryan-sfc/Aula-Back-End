//Herança
//Abstração
//Encapsulamento
//polimorfismo

using PilaresPOO.Classes.Aprendizagem;

Aluno joao = new Aluno();
joao.Nome = "Joao";

Console.WriteLine($"{joao.Nome} Nasceu Com {joao.Idade} anos");
Console.WriteLine();

//Dados do Professor
Professor sam = new Professor(122334);
sam.Nome = "Samantha";
sam.Idade = 22;
sam.Cpf = 5674893;
sam.Salario = 2300.60f;

//Dados do Aluno
Aluno IsaacBorges = new Aluno();
IsaacBorges.Nome = "Isaac Borges";
IsaacBorges.Idade = 17;
IsaacBorges.Cpf = 40028922;
IsaacBorges.Altura = 1.83f;
IsaacBorges.Peso = 80.5f;
IsaacBorges.Matricula = 123456789;
IsaacBorges.Curso = "Dev";
IsaacBorges.Media = 7.9f;

//Dados do Veiculo
Carro carro = new Carro();
carro.Marca = "BMW";
carro.Modelo = "x1";
carro.Cor = "Preto";
carro.Potencia = 300;
carro.QtdPassageiros = 5;
carro.QtdPortas = 4;

Moto moto = new Moto();
moto.Marca = "Honda";
moto.Modelo = "160 Start";
moto.Cor = "Preto";
moto.Potencia = 160;
moto.QtdPassageiros = 2;
moto.QtdRodas = 2;

Aviao aviao = new Aviao();
aviao.Marca = "Gol";
aviao.Modelo = "Boing";
aviao.Cor = "Branco";
aviao.Potencia = 160000;
aviao.QtdPassageiros = 120;
aviao.QtdPortas = 2;

//Exibição dos Dados do Aluno
Console.WriteLine($"Aluno: {IsaacBorges.Nome}");
Console.WriteLine($"Idade: {IsaacBorges.Idade}");
Console.WriteLine($"CPF: {IsaacBorges.Cpf}");
Console.WriteLine($"Altura: {IsaacBorges.Altura}");
Console.WriteLine($"Peso: {IsaacBorges.Peso}");
Console.WriteLine($"Idade após alguns anos: {IsaacBorges.Envelhecer}");
Console.WriteLine($"Ganho de peso");
Console.WriteLine($"Matricula: {IsaacBorges.Matricula}");
Console.WriteLine($"Curso: {IsaacBorges.Curso}");
Console.WriteLine($"Média: {IsaacBorges.Media}");
Console.WriteLine();

//Exibição dos Dados do Professor
Console.WriteLine($"Nome: {sam.Nome}");
Console.WriteLine($"Idade: {sam.Idade}");
Console.WriteLine($"Idade: {sam.Cpf}");
Console.WriteLine($"Identificação do Professor: {sam.NIF}");
Console.WriteLine($"Salário: {sam.Salario}");
Console.WriteLine();


//Exibição dos Dados dos Veiculos
Console.WriteLine($"Moto:");
Console.WriteLine($"Marca: {carro.Marca}");
Console.WriteLine($"Modelo: {carro.Modelo}");
Console.WriteLine($"Cor: {carro.Cor}");
Console.WriteLine($"Potencia: {carro.Potencia}");
Console.WriteLine($"Quantidade de Passageiros: {carro.QtdPassageiros}");
Console.WriteLine($"Quantidade de Portas: {carro.QtdPortas}");
moto.Ligar();
moto.Desligar();
moto.Buzinar();
Console.WriteLine();

Console.WriteLine($"Carro:");
Console.WriteLine($"Marca: {moto.Marca}");
Console.WriteLine($"Modelo: {moto.Modelo}");
Console.WriteLine($"Cor: {moto.Cor}");
Console.WriteLine($"Potencia: {moto.Potencia}");
Console.WriteLine($"Quantidade de Passageiros: {moto.QtdPassageiros}");
Console.WriteLine($"Quantidade de Portas: {moto.QtdRodas}");
carro.Ligar();
carro.Desligar();
carro.Buzinar();
Console.WriteLine();

Console.WriteLine($"Avião:");
Console.WriteLine($"Marca: {aviao.Marca}");
Console.WriteLine($"Modelo: {carro.Modelo}");
Console.WriteLine($"Cor: {aviao.Cor}");
Console.WriteLine($"Potencia: {aviao.Potencia}");
Console.WriteLine($"Quantidade de Passageiros: {aviao.QtdPassageiros}");
Console.WriteLine($"Quantidade de Portas: {aviao.QtdPortas}");
aviao.Ligar();
aviao.Desligar();
aviao.Buzinar();
Console.WriteLine();

