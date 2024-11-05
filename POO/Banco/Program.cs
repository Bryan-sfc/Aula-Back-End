using System.Security.Permissions;
using Banco;
using Banco.Classes;

Console.WriteLine($"Bem Vindo ao Nubenquinho");
Console.WriteLine();

ContaCorrente contaBryan = new ContaCorrente();
ContaCorrente contaThalia = new ContaCorrente();

contaBryan.Titular = "Bryan";
contaBryan.Depositar(1000000f);

contaThalia.Titular = "Thalia";
contaThalia.Depositar(1000000f);

Console.WriteLine($"Conta de {contaBryan.Titular} tem R${contaBryan.saldo},00");
Console.WriteLine($"Conta de {contaThalia.Titular} tem R${contaThalia.saldo},00");
Console.WriteLine();


contaBryan.Sacar(250f);

Console.WriteLine($"Você sacou e sua conta ficou com R${contaBryan.saldo}");
Console.WriteLine();


Console.WriteLine($"Conta de {contaBryan.Titular} tem R${contaBryan.saldo},00");
Console.WriteLine($"Conta de {contaThalia.Titular} tem R${contaThalia.saldo},00");
Console.WriteLine();