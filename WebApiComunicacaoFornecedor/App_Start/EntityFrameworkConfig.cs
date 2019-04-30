using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiComunicacaoFornecedor.Models;
using WebApiComunicacaoFornecedor.Models.EF;
using WebApiComunicacaoFornecedor.Security;

namespace WebApiComunicacaoFornecedor
{
    public class EntityFrameworkConfig
    {
        public static void EntityFrameworkConfigStart()
        {
            using (var ctx = new DropShippingContext())
            {
                
                var prod1 = new Produto() { produtoId = 1, nome = "Smartphone Motorola Moto G7 Play 32GB Dual Chip Android 4G Câmera 13MP", quantComprada = 1, preco = 5000};
                var prod2 = new Produto() { produtoId = 2, nome = "Celular Samsung Galaxy J6+ 2 Chip", quantComprada = 1, preco = 3000 };
                var prod3 = new Produto() { produtoId = 3, nome = "Celular Samsung Galaxy J2 Prime 16gb", quantComprada = 1, preco =45000 };
                var prod4 = new Produto() { produtoId = 4, nome = "iPhone 7 32GB Preto Matte Desbloqueado IOS 10 Wi - fi + 4G Câmera 12MP", quantComprada = 1, preco = 55000 };
                var prod5 = new Produto() { produtoId = 5, nome = "iPhone 6 32GB Dourado IOS 8, Câmera 8MP, 4G Processador 1.4 Ghz Dual Core", quantComprada = 1, preco = 4000 };
                var prod6 = new Produto() { produtoId = 6, nome = "Smartphone Asus Zenfone 5 64GB Dual Chip Android 4G Câmera 12MP Prata", quantComprada = 1, preco = 2300 };

                ctx.Produtos.Add(prod1);
                ctx.Produtos.Add(prod2);
                ctx.Produtos.Add(prod3);
                ctx.Produtos.Add(prod4);
                ctx.Produtos.Add(prod5);
                ctx.Produtos.Add(prod6);

                var pedido1 = new Pedido { pedidoId = 1, clienteId = 10 };
                var pedido2 = new Pedido { pedidoId = 2, clienteId = 20 };

                ctx.Pedidos.Add(pedido1);
                ctx.Pedidos.Add(pedido2);

                var prodPedidos1 = new ProdutosPedido { pedidoId = 1, produtoId = 1 };
                var prodPedidos2 = new ProdutosPedido { pedidoId = 2, produtoId = 2 };
                var prodPedidos3 = new ProdutosPedido { pedidoId = 2, produtoId = 3 };

                ctx.ProdutosPedidos.Add(prodPedidos1);
                ctx.ProdutosPedidos.Add(prodPedidos2);
                ctx.ProdutosPedidos.Add(prodPedidos3);

                var statusPedido1 = new StatusPedido { pedidoId = 1, statusId = 1, dataAtualizacao = DateTime.Now.AddDays(-2) };
                var statusPedido2 = new StatusPedido { pedidoId = 1, statusId = 2, dataAtualizacao = DateTime.Now.AddDays(-1) };
                var statusPedido3 = new StatusPedido { pedidoId = 1, statusId = 3, dataAtualizacao = DateTime.Now };


                var statusPedido4 = new StatusPedido { pedidoId = 2, statusId = 1, dataAtualizacao = DateTime.Now.AddDays(-4) };
                var statusPedido5 = new StatusPedido { pedidoId = 2, statusId = 2, dataAtualizacao = DateTime.Now.AddDays(-3) };
                var statusPedido6 = new StatusPedido { pedidoId = 2, statusId = 3, dataAtualizacao = DateTime.Now.AddDays(-2) };
                var statusPedido7 = new StatusPedido { pedidoId = 2, statusId = 4, dataAtualizacao = DateTime.Now.AddDays(-1) };
                var statusPedido8 = new StatusPedido { pedidoId = 2, statusId = 5, dataAtualizacao = DateTime.Now.AddHours(-4) };
                var statusPedido9 = new StatusPedido { pedidoId = 2, statusId = 6, dataAtualizacao = DateTime.Now };

                ctx.StatusPedidos.Add(statusPedido1);
                ctx.StatusPedidos.Add(statusPedido2);
                ctx.StatusPedidos.Add(statusPedido3);
                ctx.StatusPedidos.Add(statusPedido4);
                ctx.StatusPedidos.Add(statusPedido5);
                ctx.StatusPedidos.Add(statusPedido6);
                ctx.StatusPedidos.Add(statusPedido7);
                ctx.StatusPedidos.Add(statusPedido8);
                ctx.StatusPedidos.Add(statusPedido9);

                FornecedorSeguranca fs = new FornecedorSeguranca();
                var fornecedor = new Fornecedor
                {
                    nome = "Fornecedor SA",
                    login = "fornecedor01",
                    senha = fs.CalculateMD5Hash("senha@01"),
                    email = "fornecedor01@email.com.br"
                };
                ctx.Fornecedores.Add(fornecedor);

                ctx.SaveChanges();
            }
        }
    }
}