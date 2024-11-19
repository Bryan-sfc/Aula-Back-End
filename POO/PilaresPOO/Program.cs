using PilaresPOO.Classes.Pilares;
Console.Clear();

ContaCorrente ctLari = new ContaCorrente();
ctLari.Titular = "Larissa";
ctLari.Depositar(3000f);


Console.WriteLine($"Titular da Conta: {ctLari.Titular}");
Console.WriteLine($"Saldo da Conta: {ctLari.GetSaldo()}");
Console.WriteLine();

float ValorSacado = ctLari.Sacar(4000f);
Console.WriteLine();

Console.WriteLine($"Valor do Saque: {ValorSacado}");
Console.WriteLine($"Novo Saldo: {ctLari.GetSaldo()}");