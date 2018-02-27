using System.Collections.Generic;
using System.Linq;

namespace MovimentacaoBancaria.Dominio.Models
{
    public class Cliente
    {
        public Cliente(string cpf, string nome, string email)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Email = email;
            this.Contas = new List<ContaCorrente>();
        }

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<ContaCorrente> Contas { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.Nome}, CPF: {this.Cpf}, Qtd. Contas: {this.Contas.Count()}";
        }
    }
}
