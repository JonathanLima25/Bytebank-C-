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
        public string titular;
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
    }
}
