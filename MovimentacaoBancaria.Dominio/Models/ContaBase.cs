using System.Collections.Generic;

namespace MovimentacaoBancaria.Dominio.Models
{
    public abstract class ContaBase
    {
        public abstract void EfetuarSaque(double valor);
        public abstract void EfetuarDeposito(double valor);
        public abstract string ExibirExtrato();

        public Cliente Correntista { get; set; }
        public int Banco { get; set; }
        public int Agencia { get; set; }
        public string NumeroConta { get; set; }
        public double Saldo { get; private set; }
        public Queue<Movimentacao> Movimentos { get; set; }

        public enum TipoConta
        {
            Especial,
            Corrente
        };
    }

}
