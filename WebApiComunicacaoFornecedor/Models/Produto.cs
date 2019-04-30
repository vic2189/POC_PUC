using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiComunicacaoFornecedor.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public long produtoId { get; set; }
        
        public string nome { get; set; }
        
        public int quantComprada { get; set; }

        public decimal preco { get; set; }
    }
}