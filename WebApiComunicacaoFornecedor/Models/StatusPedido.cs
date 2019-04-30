using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiComunicacaoFornecedor.Models
{
    [Table("StatusPedidos")]
    public class StatusPedido
    {
        [Key, Column(Order = 0)]
        public long pedidoId { get; set; }
        [Key, Column(Order = 1)]
        public int statusId { get; set; }

        public DateTime dataAtualizacao { get; set; }
    }
}