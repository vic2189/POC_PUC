using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiComunicacaoFornecedor.Models.EF
{
    public class DropShippingContext : DbContext
    {
        public DropShippingContext() : base("name=DSContext")
        {
            //Database.SetInitializer<DropShippingContext>(new DropCreateDatabaseAlways<DropShippingContext>());
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<StatusPedido> StatusPedidos { get; set; }
        public DbSet<ProdutosPedido> ProdutosPedidos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}