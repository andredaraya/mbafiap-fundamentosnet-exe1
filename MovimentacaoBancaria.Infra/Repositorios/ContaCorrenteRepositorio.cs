using MovimentacaoBancaria.Dominio.Interfaces;
using MovimentacaoBancaria.Dominio.Models;
using MovimentacaoBancaria.Dominio.Utils;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MovimentacaoBancaria.Infra.Repositorios
{
    public class ContaCorrenteRepositorio : IContaCorrenteRepositorio<ContaCorrente>
    {
        private Validacao<ContaCorrente> _validaConta;
        public static List<ContaCorrente> contas;

        public ContaCorrenteRepositorio()
        {
            RegistrarValidacao();
            if (contas == null) contas = new List<ContaCorrente>();
        }

        public ContaCorrente Buscar(object key, object key2 = null)
        {
            return contas.Find((ContaCorrente c) => c.Agencia.Equals(key) && c.NumeroConta == (string)key2);
        }

        public RespostaBase Incluir(ContaCorrente conta)
        {
            RespostaBase resposta = _validaConta(conta);

            if (resposta.Sucesso)
            {
                contas.Add(conta);
                resposta.Mensagem = "Conta adicionado com sucesso.";
            }

            return resposta;
        }

        public List<ContaCorrente> Listar()
        {
            return contas;
        }

        public void RegistrarValidacao()
        {
            _validaConta = (objConta =>
            {
                RespostaBase resposta = new RespostaBase() { Sucesso = true };

                Regex regConta = new Regex(@"^\d{4}-\d{1}$", RegexOptions.None);

                if (!regConta.IsMatch(objConta.NumeroConta))
                {
                    resposta.Sucesso = false;
                    resposta.Mensagem = "Conta inválida. Formato 'xxxx-x'";
                }

                return resposta;
            });
        }
    }
}
