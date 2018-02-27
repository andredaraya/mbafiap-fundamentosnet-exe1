using MovimentacaoBancaria.Dominio.Interfaces;
using MovimentacaoBancaria.Dominio.Models;
using MovimentacaoBancaria.Dominio.Utils;
using System;
using System.IO;
using System.Text;
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

            cbxOperacao.Items.Add(TipoOperacao.Deposito);
            cbxOperacao.Items.Add(TipoOperacao.Saque);
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
            }
            else
            {
                resultado = new RespostaBase()
                {
                    Mensagem = "CPF utilizado já consta para outro cliente.",
                    Sucesso = false
                };
            }

            MessageBox.Show(resultado.Mensagem, resultado.Sucesso ? "Sucesso" : "Falha", MessageBoxButtons.OK, resultado.Sucesso ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            var clientes = this._clienteRepositorio.Listar();
            StringBuilder builder = new StringBuilder();

            foreach (var item in clientes)
            {
                builder.AppendLine(item.ToString());
            }

            txtExtrato.Text = builder.ToString();
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
            if (!txtEmail.Text.ValidarEmail())
                MessageBox.Show("E-mail inválido!");

        }

        private void btnIncluirConta_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cbxCliente.SelectedItem;
            RespostaBase resposta = new RespostaBase()
            {
                Mensagem = "Houve algum problema",
                Sucesso = false
            };

            if (rdbContaComum.Checked)
            {
                ContaCorrente cc = new ContaCorrente()
                {
                    Agencia = int.Parse(txtAgencia.Text),
                    Banco = int.Parse(txtBanco.Text),
                    Correntista = (Cliente)cbxCliente.SelectedItem,
                    NumeroConta = txtConta.Text
                };

                if (_cCorrenteRepositorio.Buscar(cc.Agencia, cc.NumeroConta) == null)
                {
                    resposta = _cCorrenteRepositorio.Incluir(cc);
                    cbxConta.Items.Add(cc);
                }
                else
                {
                    resposta = new RespostaBase()
                    {
                        Sucesso = false,
                        Mensagem = "Conta já cadastrada"
                    };
                }

            }
            else if (rdbContaEspecial.Checked)
            {
                ContaEspecial ce = new ContaEspecial()
                {
                    Agencia = int.Parse(txtAgencia.Text),
                    Banco = int.Parse(txtBanco.Text),
                    Correntista = (Cliente)cbxCliente.SelectedItem,
                    NumeroConta = txtConta.Text,
                    Limite = double.Parse(txtLimite.Text)
                };

                if (_cEspecialRepositorio.Buscar(ce.Agencia, ce.NumeroConta) == null)
                {
                    resposta = _cEspecialRepositorio.Incluir(ce);
                    cbxConta.Items.Add(ce);
                }
                else
                {
                    resposta = new RespostaBase()
                    {
                        Sucesso = false,
                        Mensagem = "Conta já cadastrada."
                    };
                }
            }

            MessageBox.Show(resposta.Mensagem, resposta.Sucesso ? "Sucesso" : "Falha", MessageBoxButtons.OK, resposta.Sucesso ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        private void rdbContaComum_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbContaComum.Checked) txtLimite.Enabled = false; else txtLimite.Enabled = true;
        }

        private void rdbContaEspecial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbContaEspecial.Checked) txtLimite.Enabled = true; else txtLimite.Enabled = false;
        }

        private void txtBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtAgencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnExecOpe_Click(object sender, EventArgs e)
        {
            TipoOperacao operacao = (TipoOperacao)cbxOperacao.SelectedItem;
            RespostaBase resposta = new RespostaBase()
            {
                Mensagem = string.Empty,
                Sucesso = false
            };

            switch (operacao)
            {
                case TipoOperacao.Deposito:
                    if (cbxConta.SelectedItem.GetType() == typeof(ContaCorrente))
                    {
                        ContaCorrente cc = (ContaCorrente)cbxConta.SelectedItem;
                        resposta = cc.EfetuarDeposito(double.Parse(txtValor.Text));
                    }
                    else
                    {
                        ContaEspecial ce = (ContaEspecial)cbxConta.SelectedItem;
                        resposta = ce.EfetuarDeposito(double.Parse(txtValor.Text));
                    }
                    break;
                case TipoOperacao.Saque:
                    if (cbxConta.SelectedItem.GetType() == typeof(ContaCorrente))
                    {
                        ContaCorrente cc = (ContaCorrente)cbxConta.SelectedItem;
                        resposta = cc.EfetuarSaque(double.Parse(txtValor.Text));
                    }
                    else
                    {
                        ContaEspecial cc = (ContaEspecial)cbxConta.SelectedItem;
                        resposta = cc.EfetuarSaque(double.Parse(txtValor.Text));
                    }
                    break;
            }

            MessageBox.Show(resposta.Mensagem, resposta.Sucesso ? "Sucesso" : "Operação não efetuada", MessageBoxButtons.OK, resposta.Sucesso ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private void btnExibirExtrato_Click(object sender, EventArgs e)
        {
            if (cbxConta.SelectedItem.GetType() == typeof(ContaCorrente))
            {
                txtExtrato.Text = ((ContaCorrente)cbxConta.SelectedItem).ExibirExtrato();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGravarExtrato_Click(object sender, EventArgs e)
        {
            if (cbxConta.SelectedItem.GetType() == typeof(ContaCorrente))
            {
                saveFileDialog1.Filter = "Text File | *.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, txtExtrato.Text);
                    MessageBox.Show("Extrato salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Emissão de extrato cancelada.", "Operação cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("Operação não é valida para esse tipo de conta", "Operação inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
