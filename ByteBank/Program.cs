
using ByteBank;

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "1010-X";
conta1.numero_agencia = 15;
conta1.saldo = 100;

Console.WriteLine("Saldo de antes do deposito: R$"+conta1.saldo);

conta1.Depositar(100);

Console.WriteLine("Saldo de depois do deposito: R$" + conta1.saldo);

Console.WriteLine("--------------------------------------------");

Console.WriteLine($"Titular da conta {conta1.titular}");
Console.WriteLine($"Número da conta {conta1.conta}");
Console.WriteLine($"Número da agencia {conta1.numero_agencia}");
Console.WriteLine($"Saldo da conta {conta1.saldo}");

Console.WriteLine("--------------------------------------------");

if (conta1.Sacar(30) == true)
{
    Console.WriteLine($"Saldo atual da conta {conta1.saldo}");
}
else
{
    Console.WriteLine("Saldo insulficiente.");
}
