
using ByteBank;

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "1010-X";
conta1.numero_agencia = 15;
conta1.saldo = 100;

Console.WriteLine("Saldo de antes do deposito: R$"+conta1.saldo);

conta1.Depositar(100);

Console.WriteLine("Saldo de depois do deposito: R$" + conta1.saldo);