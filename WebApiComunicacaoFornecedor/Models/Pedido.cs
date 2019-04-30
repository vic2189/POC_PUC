using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiComunicacaoFornecedor.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        public long pedidoId { get; set; }

        public long clienteId { get; set; }

        public List<ProdutosPedido> listaProdutosPedido { get; set; }

        public List<StatusPedido> listaStatusPedido { get; set; }

    }
}