namespace WebApiComunicacaoFornecedor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Pedidoes", newName: "Pedidos");
            RenameTable(name: "dbo.ProdutosPedidoes", newName: "ProdutosPedidos");
            RenameTable(name: "dbo.StatusPedidoes", newName: "StatusPedidos");
            RenameTable(name: "dbo.Produtoes", newName: "Produtos");
            CreateTable(
                "dbo.Fornecedores",
                c => new
                    {
                        fornecedorId = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        login = c.String(),
                        senha = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.fornecedorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fornecedores");
            RenameTable(name: "dbo.Produtos", newName: "Produtoes");
            RenameTable(name: "dbo.StatusPedidos", newName: "StatusPedidoes");
            RenameTable(name: "dbo.ProdutosPedidos", newName: "ProdutosPedidoes");
            RenameTable(name: "dbo.Pedidos", newName: "Pedidoes");
        }
    }
}
