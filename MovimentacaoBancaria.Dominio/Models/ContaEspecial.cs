using System;

namespace MovimentacaoBancaria.Dominio.Models
{
    public class ContaEspecial : ContaBase
    {
        public double Limite { get; set; }

        public override RespostaBase EfetuarDeposito(double valor)
        {
            void deposito(ContaBase conta, double v) => conta.Saldo += v;

            deposito(this, valor);            

            return new RespostaBase()
            {
                Mensagem = "Deposito efetuado com sucesso",
                Sucesso = true
            };
        }

        public override RespostaBase EfetuarSaque(double valor)
        {
            void saque(ContaBase conta, double v) => conta.Saldo -= v;

            if (this.Saldo > 0 && this.Saldo >= valor && valor <= this.Limite)
            {
                saque(this, valor);                

                return new RespostaBase()
                {
                    Mensagem = "Saque efetuado com sucesso",
                    Sucesso = true
                };
            }
            else if ( valor > this.Limite)
            {
                return new RespostaBase()
                {
                    Mensagem = "Valor ultrapassa o limite de saque.",
                    Sucesso = false
                };
            } else
            {
                return new RespostaBase()
                {
                    Mensagem = "Não há saldo sufiente",
                    Sucesso = false
                };
            }
        }

        public override string ExibirExtrato()
        {
            return $"Operação não disponível para este tipo de conta.";
        }        
    }
}
