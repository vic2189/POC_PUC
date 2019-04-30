using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalvarComprasCliente.EF
{
    [Table("HistoricoComprasCliente")]
    public class HistoricoCompras
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long historicoComprasId { get; set; }
        public long pedidoId { get; set; }
        public string formaPagamento { get; set; }
        public long clienteId { get; set; }
        public string dataCompra { get; set; }
        public void GravarCompra()
        {            
            try
            {
                using (var ctx = new DropShippingContext())
                {
                    var historicoCompras = new HistoricoCompras()
                    {
                        clienteId = this.clienteId,
                        formaPagamento = this.formaPagamento,
                        pedidoId = this.pedidoId,
                        dataCompra = this.dataCompra,
                    };
                    ctx.HistoricoCompras.Add(historicoCompras);

                    ctx.SaveChanges();
                   
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Erro:" + ex.StackTrace);
                
            }
        }
    }
}