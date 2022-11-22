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
        public int numero_agencia;
        public string conta;
        public Cliente titular;
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
            Console.WriteLine($"Titular: {titular.nome}");
            Console.WriteLine($"Número da conta: {conta}, Número da agencia: {numero_agencia}");
            Console.WriteLine($"Saldo da conta: {saldo}");
        }
    }
}
