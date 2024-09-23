
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
         ClienteEntindade BuscarPorId(int id);
        void Incluir(ClienteEntindade cliente);
        void Atualizar(ClienteEntindade cliente);
        void Apagar(ClienteEntindade cliente);
    }
}
