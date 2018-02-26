using System;

namespace MovimentacaoBancaria.Dominio.Models
{
    public class Movimentacao
    {
        public Movimentacao(ContaCorrente conta, DateTime data, double valor)
        {
            this.Conta = conta;
            this.Data = data;
            this.Valor = valor;
        }

        public ContaCorrente Conta { get; private set; }
        public DateTime Data { get; private set; }
        public string Historico { get; private set; }
        public double Valor { get; private set; }
    }
}
