using MovimentacaoBancaria.Dominio.Models;

namespace MovimentacaoBancaria.Dominio.Utils
{
    public delegate RespostaBase Validacao<T>(T obj);
    public delegate double Operacao<T>(T obj, double valor);
}
