using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiComunicacaoFornecedor.Models;
using WebApiComunicacaoFornecedor.Models.EF;

namespace WebApiComunicacaoFornecedor.Controllers
{
    [Authorize]
    public class DropShippingController : ApiController
    {

        [Route("dropshipping/statusPedido")]
        [HttpPut]
        public IHttpActionResult AtualizaStatusPedido(StatusPedido statusPedido)
        {
            using (var ctx = new DropShippingContext())
            {
                var existePedido = ctx.Pedidos.Where(p => p.pedidoId == statusPedido.pedidoId)
                                                    .FirstOrDefault<Pedido>();
                if (existePedido != null)
                {
                    ctx.StatusPedidos.Add(new StatusPedido() { pedidoId = statusPedido.pedidoId,
                                                               statusId = statusPedido.statusId,
                                                               dataAtualizacao = DateTime.Now});

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
                return Ok();
        }
    }
}
