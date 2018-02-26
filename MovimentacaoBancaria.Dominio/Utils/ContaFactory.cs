using MovimentacaoBancaria.Dominio.Models;
using System;
using static MovimentacaoBancaria.Dominio.Models.ContaBase;

namespace MovimentacaoBancaria.Dominio.Utils
{
    public static class ContaFactory
    {
        public static ContaBase Criar(TipoConta tipoConta)
        {
            switch (tipoConta)
            {
                case TipoConta.Especial:
                    return new ContaEspecial();
                case TipoConta.Corrente:
                    return new ContaCorrente();
                default:
                    throw new InvalidOperationException("Tipo de conta não identificado");
            }
        }
    }
}
