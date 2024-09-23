using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMSAPI.Entidades
{
   public class ClienteEntindade
    {
        public ClienteEntindade()
        {
        }

        public ClienteEntindade(int codigo, string nome, DateTime dataNascimento, string email, string cPF, string endereco)
        {
            Codigo = codigo;
            Nome = nome;
            DataNascimento = dataNascimento;
            Email = email;
            CPF = cPF;
            Endereco = endereco;
            DataCadastro = DateTime.Now;
          
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }


    }
}
