using System;

namespace MovimentacaoBancaria.Dominio.Models
{
    public class ContaEspecial : ContaBase
    {
        public double Limite { get; set; }

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
