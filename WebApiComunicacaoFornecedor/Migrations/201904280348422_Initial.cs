namespace WebApiComunicacaoFornecedor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        pedidoId = c.Long(nullable: false, identity: true),
                        clienteId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.pedidoId);
            
            CreateTable(
                "dbo.ProdutosPedidoes",
                c => new
                    {
                        pedidoId = c.Long(nullable: false),
                        produtoId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.pedidoId, t.produtoId })
                .ForeignKey("dbo.Pedidoes", t => t.pedidoId, cascadeDelete: true)
                .Index(t => t.pedidoId);
            
            CreateTable(
                "dbo.StatusPedidoes",
                c => new
                    {
                        pedidoId = c.Long(nullable: false),
                        statusId = c.Int(nullable: false),
                        dataAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.pedidoId, t.statusId })
                .ForeignKey("dbo.Pedidoes", t => t.pedidoId, cascadeDelete: true)
                .Index(t => t.pedidoId);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        produtoId = c.Long(nullable: false, identity: true),
                        nome = c.String(),
                        quantComprada = c.Int(nullable: false),
                        preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.produtoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StatusPedidoes", "pedidoId", "dbo.Pedidoes");
            DropForeignKey("dbo.ProdutosPedidoes", "pedidoId", "dbo.Pedidoes");
            DropIndex("dbo.StatusPedidoes", new[] { "pedidoId" });
            DropIndex("dbo.ProdutosPedidoes", new[] { "pedidoId" });
            DropTable("dbo.Produtoes");
            DropTable("dbo.StatusPedidoes");
            DropTable("dbo.ProdutosPedidoes");
            DropTable("dbo.Pedidoes");
        }
    }
}
