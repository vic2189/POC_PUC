using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebServiceFornecedor.Produtos
{
    public class BaseDados
    {
        //Criando dados fictícios dos produtos
        private DataTable DadosProduto()
        {
            DataTable dtDadosProd = new DataTable();
            dtDadosProd.Columns.Add("cod_produto");
            dtDadosProd.Columns.Add("nom_produto");
            dtDadosProd.Columns.Add("quant_estoque");


            dtDadosProd.Rows.Add(1, "Smartphone Motorola Moto G7 Play 32GB Dual Chip Android 4G Câmera 13MP", "25");
            dtDadosProd.Rows.Add(2, "Celular Samsung Galaxy J6+ 2 Chip", "60");
            dtDadosProd.Rows.Add(3, "Celular Samsung Galaxy J2 Prime 16gb", "0");
            dtDadosProd.Rows.Add(4, "iPhone 7 32GB Preto Matte Desbloqueado IOS 10 Wi - fi + 4G Câmera 12MP", "85");
            dtDadosProd.Rows.Add(5, "iPhone 6 32GB Dourado IOS 8, Câmera 8MP, 4G Processador 1.4 Ghz Dual Core", "6");
            dtDadosProd.Rows.Add(6, "Smartphone Asus Zenfone 5 64GB Dual Chip Android 4G Câmera 12MP Prata", "21");

            return dtDadosProd;
        }

        public Produto ObterProduto(string idProduto)
        {
            //Criando lista de produtos
            List<Produto> produtos = new List<Produto>();

            Produto produto;

            foreach (DataRow row in DadosProduto().Rows)
            {
                produto = new Produto();
                produto.codProduto = row["cod_produto"].ToString();
                produto.nomProduto = row["nom_produto"].ToString();
                produto.quantEstoque = row["quant_estoque"].ToString();
                produtos.Add(produto);
            }

            //Filtrando produto
            var result = from p in produtos
                         where p.codProduto.Equals(idProduto)
                         select p;
            if (result == null || result.Count() == 0)
            {
                return new Produto();
            }
            else
            {
                Produto produtoSelecionado = (Produto)result.First();
                return produtoSelecionado;
                
            }
            
        }
    }
}