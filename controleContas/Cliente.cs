using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public int AnoNascimento { get; private set; }
        public string Cpf { get; private set; }
        public string tel { get; private set; }

        public Cliente(string nome, int anoNascimento, string cpf)
        {
            Nome = nome;
            AnoNascimento = anoNascimento;
            Cpf = cpf;

        }
    }
}
