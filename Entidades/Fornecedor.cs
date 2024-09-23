using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMSAPI.Entidades
{
    public class Fornecedor
    {
        public Fornecedor(int codigo, string nome, string razaoSocial, string email, string cNPJ, string endereco)
        {
            Codigo = codigo;
            Nome = nome;
            RazaoSocial = razaoSocial;
            Email = email;
            CNPJ = cNPJ;
            Endereco = endereco;
            DataCadastro = DateTime.Now;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string Email { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
