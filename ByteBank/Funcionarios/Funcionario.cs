using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }

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
        public double Salario { get; set; }
        public double GetBonificacao()
        {
            return this.Salario * 0.10;
        }
    }
}
