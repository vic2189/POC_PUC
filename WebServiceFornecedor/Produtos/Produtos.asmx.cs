using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Xml.Serialization;

namespace WebServiceFornecedor.Produtos
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Produtos : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        public xml obterEstoqueProduto(string idProduto)
        {
            //Base dos produtos
            BaseDados bd = new BaseDados();
       
            //Popular a Classe xml
            xml dadosXML = new xml(bd.ObterProduto(idProduto));
            //Retornar o xml
            return dadosXML;
        }


        //Classe que recebe produto e retorna o XML
        [XmlRoot("xml")]
        public class xml
        {
            public xml() { }
            public xml(Produto produto)
            {
                this.produto = produto;
            }
            public Produto produto { get; set; }
        }   
        
    }
}
