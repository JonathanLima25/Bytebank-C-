using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public Cliente titular;
        public double saldo;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(this.saldo >= valor)
            {    
                this.saldo -= valor;
                return true;
            }
            return false;
        }
        public bool Transferir(double valor, ContaCorrente destino) 
        {
            if(this.Sacar(valor)==true) 
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
            Console.WriteLine($"Titular: {this.titular.nome}");
            Console.WriteLine($"Número da conta: {this.conta}, Número da agencia: {this.numero_agencia}");
            Console.WriteLine($"Saldo da conta: {this.saldo}");
        }
    }
}
