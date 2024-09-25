using FORMSAPI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMSAPI.Interfaces
{
   public  interface IFornecedor
    {
        Task<List<FornecedorEntidade>> Todos();
        FornecedorEntidade BuscarPorId(int codigo);
        Task<bool> Incluir(FornecedorEntidade cliente);
        Task<bool> Atualizar(FornecedorEntidade cliente, int codigo);
        Task<bool> Apagar(int codigo);
    }
}
