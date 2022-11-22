using ByteBank.Contas;
using ByteBank.Titular;

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "André Silva";
//conta1.conta = "1010-X";
//conta1.numero_agencia = 15;
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Leonardo Silva";
//conta2.conta = "1111-A";
//conta2.numero_agencia = 14;
//conta2.saldo = 0;

//Console.WriteLine("Saldo de antes do deposito: R$"+conta1.saldo);

//conta1.Depositar(100);

//Console.WriteLine("Saldo de depois do deposito: R$" + conta1.saldo);

//Console.WriteLine("--------------------------------------------");

//conta1.ExibiConta();

//Console.WriteLine("--------------------------------------------");

//if (conta1.Sacar(30) == true)
//{
//    Console.WriteLine($"Saldo atual da conta {conta1.saldo}");
//}
//else
//{
//    Console.WriteLine("Saldo insulficiente.");
//}
//conta1.Transferir(100, conta2);

//Console.WriteLine($"Saldo da conta 1 {conta1.saldo}");
//Console.WriteLine($"Saldo da conta 2 {conta2.saldo}");

Cliente cliente = new Cliente();
cliente.nome = "Jonathan de Lima";
cliente.cpf = "213-123";
cliente.profissao = "Telemarketing";

ContaCorrente conta= new ContaCorrente();
conta.titular = cliente;
conta.conta = "1015-X";
conta.numero_agencia= 1;
conta.Depositar(100);

Console.WriteLine($"Titular da conta: {conta.titular.nome}");
conta.ExibiConta();
