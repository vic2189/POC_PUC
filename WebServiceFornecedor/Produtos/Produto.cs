using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServiceFornecedor.Produtos
{
    public class Produto
    {

        [XmlElement("cod_produto")]
        public string codProduto { get; set; }

        [XmlElement("nom_produto")]
        public string nomProduto { get; set; }

        [XmlElement("quant_estoque")]
        public string quantEstoque { get; set; }
    }
}