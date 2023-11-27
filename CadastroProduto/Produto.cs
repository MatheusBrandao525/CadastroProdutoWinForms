using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto
{
    public class Produto
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Fornecedor { get; set; }
        public decimal Valor { get; set; }
        public string Estoque { get; set; }
        public bool Disponivel { get; set; }

        public Produto(string varcodigo, string vardescricao, string varfornecedor, decimal varvalor, string varestoque, bool vardisponivel)
        {
            Codigo = varcodigo;
            Descricao = vardescricao;
            Fornecedor = varfornecedor;
            Valor = varvalor;
            Estoque = varestoque;
            Disponivel = vardisponivel;
        }
    }

}
