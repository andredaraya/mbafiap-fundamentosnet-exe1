using MovimentacaoBancaria.Dominio.Interfaces;
using MovimentacaoBancaria.Dominio.Models;
using MovimentacaoBancaria.Dominio.Utils;
using System.Collections.Generic;

namespace MovimentacaoBancaria.Infra.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio<Cliente>
    {
        private Validacao<Cliente> _validaCliente;
        public static List<Cliente> clientes;

        public ClienteRepositorio()
        {
            RegistrarValidacao();
            if (clientes == null) clientes = new List<Cliente>();
        }

        public RespostaBase Incluir(Cliente cliente)
        {
            RespostaBase resposta = _validaCliente(cliente);

            if (resposta.Sucesso)
            {
                clientes.Add(cliente);
                resposta.Mensagem = "Cliente adicionado com sucesso.";
            }

            return resposta;
        }

        public List<Cliente> Listar()
        {
            return clientes ?? new List<Cliente>();
        }

        public void RegistrarValidacao()
        {
            _validaCliente = (objCliente =>
            {
                RespostaBase resposta = new RespostaBase() { Sucesso = true };

                if (!objCliente.Email.ValidarEmail())
                {
                    resposta.Sucesso = false;
                    resposta.Mensagem = "E-mail inválido";
                }

                if(!objCliente.Cpf.ValidarCpf())
                {
                    resposta.Sucesso = false;
                    resposta.Mensagem = "CPF inválido";
                }

                return resposta;
            });
        }

        public Cliente Buscar(object key, object key2 = null)
        {
            return clientes.Find(c => c.Cpf.Equals(key));
        }
    }
}
