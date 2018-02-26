using MovimentacaoBancaria.Dominio.Interfaces;
using MovimentacaoBancaria.Dominio.Models;
using MovimentacaoBancaria.Dominio.Utils;
using System;
using System.Windows.Forms;
using static MovimentacaoBancaria.Dominio.Models.ContaBase;

namespace MovimentacaoBancaria
{
    public partial class Form1 : Form
    {
        private readonly IClienteRepositorio<Cliente> _clienteRepositorio;
        private readonly IContaCorrenteRepositorio<ContaCorrente> _cCorrenteRepositorio;
        private readonly IContaEspecialRepositorio<ContaEspecial> _cEspecialRepositorio;

        public Form1(IClienteRepositorio<Cliente> clienteRepositorio, 
                    IContaCorrenteRepositorio<ContaCorrente> cCorrenteRepositorio, 
                    IContaEspecialRepositorio<ContaEspecial> cEspecialRepositorio)
        {
            this._clienteRepositorio = clienteRepositorio;
            this._cCorrenteRepositorio = cCorrenteRepositorio;
            this._cEspecialRepositorio = cEspecialRepositorio;

            InitializeComponent();
        }

        private void btnIncluirCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtCpf.Text, txtNome.Text, txtEmail.Text);
            RespostaBase resultado;

            Cliente clienteCadastrado = this._clienteRepositorio.Buscar(cliente.Cpf);
            if (clienteCadastrado == null)
            {
                resultado = this._clienteRepositorio.Incluir(cliente);

                if (resultado.Sucesso)
                {
                    txtCpf.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtEmail.Text = string.Empty;

                    cbxCliente.Items.Add(cliente);
                }
            } else
            {
                resultado = new RespostaBase()
                {
                    Mensagem = "CPF utilizado já consta para outro cliente.",
                    Sucesso = false
                };
            }

            MessageBox.Show(resultado.Mensagem);
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            var clientes = this._clienteRepositorio.Listar();

            listBoxResultado.Items.Clear();
            clientes.ForEach(cli => listBoxResultado.Items.Add(cli.ToString()));
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            txtCpf.Text = txtCpf.Text.FormatarCpf();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            txtNome.Text = txtNome.Text.FormatarTexto();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(!txtEmail.Text.ValidarEmail())
                MessageBox.Show("E-mail inválido!");
            
        }

        private void btnIncluirConta_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cbxCliente.SelectedItem;
            var conta = ContaFactory.Criar(rdbContaComum.Checked ? 
                                                        TipoConta.Corrente : 
                                                        TipoConta.Especial);

            conta.Agencia = int.Parse(txtAgencia.Text);
            conta.Banco = int.Parse(txtBanco.Text);
            conta.NumeroConta = txtConta.Text;

            if (conta.GetType() == typeof(ContaEspecial))
            {
                ((ContaEspecial)conta).Limite = double.Parse(txtLimite.Text);
            }
        }
    }
}
