using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMSAPI.Entidades
{
    public class Produto
    {
        public Produto(int codigo, string nome, string descricao, int quantidade, int codigoFornecedor, double valorUnitario)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
            CodigoFornecedor = codigoFornecedor;
            ValorUnitario = valorUnitario;
            DataCadastro = DataCadastro = DateTime.Now;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int CodigoFornecedor  { get; set; }
        public Double ValorUnitario { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
