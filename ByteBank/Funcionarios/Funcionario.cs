﻿using System;
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
        Match match;
        string pattern = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
        public string Cpf { get; private set; }
        public double Salario { get; set; }
        public static int TotalFuncionario { get; private set; }
        public virtual double GetBonificacao()
        {
            return this.Salario * 0.10;
        }
        public Funcionario(string cpf)
        {
            match = Regex.Match(cpf, pattern);
            if (match.Success)
            {
                this.Cpf = cpf;
            }
            else
            {
                Console.WriteLine("CPF invalido");
            }
            TotalFuncionario++;
            Console.WriteLine("Criando um funcionário.");
        }
    }
}
