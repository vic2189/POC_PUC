using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace WebApiComunicacaoFornecedor.Controllers
{
    public class FornecedorController : ApiController
    {

        [Route("fornecedor/estoqueProduto")]
        [HttpGet]
        public IHttpActionResult EstoqueProdutoFornecedor(string idProduto)
        {
            ServiceReferenceEstoqueFornecedor.ProdutosSoapClient s = new ServiceReferenceEstoqueFornecedor.ProdutosSoapClient();
            ServiceReferenceEstoqueFornecedor.xml xml = s.obterEstoqueProduto(idProduto);

            return new TextResult(String.Format("Codigo Produto:{0}; Quantidade Estoque:{1}",xml.produto.cod_produto, xml.produto.quant_estoque), Request);
        }

        //[Route("fornecedor/token")]
        //[HttpGet]
        //public IHttpActionResult EstoqueProdutoFornecedor(string idProduto)
        //{
        //    ServiceReferenceEstoqueFornecedor.ProdutosSoapClient s = new ServiceReferenceEstoqueFornecedor.ProdutosSoapClient();
        //    ServiceReferenceEstoqueFornecedor.xml xml = s.obterEstoqueProduto(idProduto);

        //    return new TextResult(xml.produto.nom_produto, Request);
        //}
    }

    public class TextResult : IHttpActionResult
    {
        string _value;
        HttpRequestMessage _request;

        public TextResult(string value, HttpRequestMessage request)
        {
            _value = value;
            _request = request;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage()
            {
                Content = new StringContent(_value),
                RequestMessage = _request
            };
            return Task.FromResult(response);
        }
    }
}
