using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Titular;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        
        public int Numero_agencia { get; set; }
        
        public string Conta { get; set; }
        public Cliente Titular { get; set; }

        private double saldo;

        public bool Depositar(double valor)
        {
            if(valor<=0)
            {
                return false;
            }
            saldo += valor;
            return true;
        }

        public bool Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (Sacar(valor) == true)
            {
                destino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ExibiConta()
        {
            Console.WriteLine($"Titular: {Titular.Nome}");
            Console.WriteLine($"Número da conta: {Conta}, Número da agencia: {Numero_agencia}");
            Console.WriteLine($"Saldo da conta: {saldo}");
        }
        public ContaCorrente(int numero_agencia, string conta, Cliente titular)
        {
            Numero_agencia = numero_agencia;
            Conta = conta;
            Titular = titular;
        }
    }
}
