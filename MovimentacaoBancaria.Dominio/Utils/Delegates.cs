using MovimentacaoBancaria.Dominio.Models;

namespace MovimentacaoBancaria.Dominio.Utils
{
    public delegate RespostaBase Validacao<T>(T obj);
    public delegate bool Operacao<T>(T obj);
}
