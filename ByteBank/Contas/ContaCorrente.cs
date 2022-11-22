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
        private int _numero_agencia;
        public int Numero_agencia
        {
            get { return this._numero_agencia; }
            set { this._numero_agencia = value; }
        }
        private string _conta;
        public string Conta
        {
            get { return this._conta; }
            set { this._conta = value; }
        }
        private Cliente _titular;
        public Cliente Titular
        {
            get { return this._titular; }
            set { this._titular = value;}
        }
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
            Console.WriteLine($"Titular: {_titular.Nome}");
            Console.WriteLine($"Número da conta: {_conta}, Número da agencia: {_numero_agencia}");
            Console.WriteLine($"Saldo da conta: {saldo}");
        }
    }
}
