using MovimentacaoBancaria.Dominio.Models;
using System.Collections.Generic;

namespace MovimentacaoBancaria.Dominio.Interfaces
{
    public interface IRepositorioBase<T>
    {
        RespostaBase Incluir(T entidade);
        List<T> Listar();
        T Buscar(object key, object key2 = null);
        void RegistrarValidacao();
    }
}