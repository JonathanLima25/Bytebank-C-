using ByteBank.Contas;
using ByteBank.Funcionarios;
using ByteBank.Titular;
using ByteBank.Utilitario;

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

//Cliente cliente = new Cliente();
//cliente.Nome = "Jonathan de Lima";
//cliente.Cpf = "213.123.122-12";
//cliente.Profissao = "Telemarketing";

//ContaCorrente conta= new ContaCorrente(1, "1015-X", cliente);
//conta.Titular = cliente;
//conta.Conta = "1015-X";
//conta.Numero_agencia= 1;
//conta.Depositar(100);

//Console.WriteLine($"Titular da conta: {conta.Titular.Nome}");
//conta.ExibiConta();

Funcionario jonathan = new Funcionario("213.123.122-12", 2000);
jonathan.Nome = "Jonathan de Lima";



Console.WriteLine($"O funcionario {jonathan.Nome}, tem o salario de {jonathan.Salario} + bonificação de " +
    $"{jonathan.GetBonificacao()}.");

Diretor rachel = new Diretor("213.123.122-12", 12000);
rachel.Nome = "Rachel Nóbrega";



Console.WriteLine($"O funcionario {rachel.Nome}, tem o salario de {rachel.Salario} + bonificação de " +
    $"{rachel.GetBonificacao()}.");

GerenciadorDeBonificacao contador = new GerenciadorDeBonificacao();
contador.Registrar(jonathan);
contador.Registrar(rachel);

Console.WriteLine($"Total de bonificações é de {contador.TotalDeBoneficacao}");
Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalFuncionario);

jonathan.AumentarSalario();
rachel.AumentarSalario();


Console.WriteLine("Novo Salario do Jonathan: " + jonathan.Salario);
Console.WriteLine("Novo Salario da Rachel: " + rachel.Salario);


