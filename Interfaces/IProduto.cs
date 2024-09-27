using FORMSAPI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMSAPI.Interfaces
{
    public interface IProduto
    {
        Task<List<ProdutoEntidade>> Todos();
        ProdutoEntidade BuscarPorId(int codigo);
        Task<bool> Incluir(ProdutoEntidade produto);
        Task<bool> Atualizar(ProdutoEntidade produto, int codigo);
        Task<bool> Apagar(int codigo);
    }
}
