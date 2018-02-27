using MovimentacaoBancaria.Dominio.Interfaces;
using MovimentacaoBancaria.Dominio.Models;
using MovimentacaoBancaria.Dominio.Utils;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MovimentacaoBancaria.Infra.Repositorios
{
    public class ContaEspecialRepositorio : IContaEspecialRepositorio<ContaEspecial>
    {
        private Validacao<ContaEspecial> _validaConta;
        public static List<ContaEspecial> contas;

        public ContaEspecialRepositorio()
        {
            if (contas == null) contas = new List<ContaEspecial>();
            RegistrarValidacao();
        }

        public ContaEspecial Buscar(object key, object key2 = null)
        {
            return contas.Find((ContaEspecial c) => c.Agencia.Equals(key) && c.NumeroConta == (string)key2);
        }

        public RespostaBase Incluir(ContaEspecial conta)
        {
            RespostaBase resposta = _validaConta(conta);

            if (resposta.Sucesso)
            {
                contas.Add(conta);
                resposta.Mensagem = "Conta adicionado com sucesso.";
            }

            return resposta;
        }

        public List<ContaEspecial> Listar()
        {
            return contas;
        }

        public void RegistrarValidacao()
        {
            _validaConta = (objConta =>
            {
                RespostaBase resposta = new RespostaBase() { Sucesso = true };

                Regex regConta = new Regex(@"^\d{4}-\d{1}$");

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
