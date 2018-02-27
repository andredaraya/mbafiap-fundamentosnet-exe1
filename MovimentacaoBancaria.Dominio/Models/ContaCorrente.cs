using MovimentacaoBancaria.Dominio.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovimentacaoBancaria.Dominio.Models
{
    public class ContaCorrente : ContaBase
    {
        public ContaCorrente()
        {
            Movimentos = new Queue<Movimentacao>();
        }       

        public override RespostaBase EfetuarDeposito(double valor)
        {
            void deposito(ContaBase conta, double v) => conta.Saldo += v;

            deposito(this, valor);

            Movimentacao mov = new Movimentacao(this, DateTime.Now, valor)
            {
                Historico = $"Foram depositados R$ { valor }, novo saldo: { this.Saldo }."
            };
            this.Movimentos.Enqueue(mov);

            return new RespostaBase()
            {
                Mensagem = "Deposito efetuado com sucesso",
                Sucesso = true
            };
        }

        public override RespostaBase EfetuarSaque(double valor)
        {
            void saque(ContaBase conta, double v) => conta.Saldo -= v;

            if (this.Saldo > 0 && this.Saldo >= valor)
            {
                saque(this, valor);

                Movimentacao mov = new Movimentacao(this, DateTime.Now, valor)
                {
                    Historico = $"Foram sacados R$ { valor }, novo saldo: { this.Saldo }."
                };
                this.Movimentos.Enqueue(mov);

                return new RespostaBase()
                {
                    Mensagem = "Saque efetuado com sucesso",
                    Sucesso = true
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
            StringBuilder builder = new StringBuilder();
            foreach (var item in this.Movimentos)
            {
                builder.AppendLine(item.Historico);
            }

            return builder.ToString() + Environment.NewLine + $"Saldo disponivel na conta: R$ { this.Saldo }";
        }

        
    }
}
