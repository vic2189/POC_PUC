using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiComunicacaoFornecedor.Models
{
    [Table("ProdutosPedidos")]
    public class ProdutosPedido
    {
        [Key, Column(Order = 0)]
        public long pedidoId { get; set; }
        [Key, Column(Order = 1)]
        public long produtoId { get; set; }
    }
}