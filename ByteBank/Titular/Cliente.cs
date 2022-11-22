using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.Titular
{
    public class Cliente
    {
        private string _nome;
        public string Nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }
        private string _cpf;
        Match match;
        string pattern = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
        public string Cpf
        {
            get { return this._cpf; }
            set 
            { 
                match = Regex.Match(value, pattern);
                if (match.Success)
                {
                    this._cpf = value;
                }
                else 
                {
                    Console.WriteLine("CPF invalido");
                }
            }
        }
        private string _profissao;
        public string Profissao
        {
            get { return this._profissao; }
            set { this._profissao = value; }
        }
    }
}
