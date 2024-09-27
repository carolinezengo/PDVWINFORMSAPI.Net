
using FORMSAPI.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMSAPI.Interfaces
{
   public interface ICliente
    {
        Task <List<ClienteEntindade>>Todos();
        Task<ClienteEntindade>  BuscarPorId(int id);
        Task<bool> Incluir(ClienteEntindade cliente);
        Task<bool> Atualizar(ClienteEntindade cliente, int codigo);
        Task<bool> Apagar(int codigo);
    }
}
