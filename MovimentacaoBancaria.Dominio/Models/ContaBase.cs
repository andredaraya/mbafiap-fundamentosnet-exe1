using System.Collections.Generic;

namespace MovimentacaoBancaria.Dominio.Models
{
    public abstract class ContaBase
    {
        public abstract RespostaBase EfetuarSaque(double valor);
        public abstract RespostaBase EfetuarDeposito(double valor);
        public abstract string ExibirExtrato();

        public Cliente Correntista { get; set; }
        public int Banco { get; set; }
        public int Agencia { get; set; }
        public string NumeroConta { get; set; }
        public double Saldo { get; set; }
        public Queue<Movimentacao> Movimentos { get; set; }

        public enum TipoConta
        {
            Especial,
            Corrente
        };

        public enum TipoOperacao
        {
            Deposito,
            Saque
        }

        public override string ToString()
        {
            return $"Agencia: { this.Agencia } - Conta: { this.NumeroConta } - Cliente: { this.Correntista.Nome }";
        }
    }

}
