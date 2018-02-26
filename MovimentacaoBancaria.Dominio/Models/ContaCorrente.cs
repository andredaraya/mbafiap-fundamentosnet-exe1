using System;
using System.Collections.Generic;

namespace MovimentacaoBancaria.Dominio.Models
{
    public class ContaCorrente : ContaBase
    {
        public ContaCorrente()
        {
            Movimentos = new Queue<Movimentacao>();
        }       

        public override void EfetuarDeposito(double valor)
        {
            throw new NotImplementedException();
        }

        public override void EfetuarSaque(double valor)
        {
            throw new NotImplementedException();
        }

        public override string ExibirExtrato()
        {
            throw new NotImplementedException();
        }
    }
}
