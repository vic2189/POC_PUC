using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiComunicacaoFornecedor.Models.Enum
{
    public enum Status
    {
        Efetuado = 1,
        Aprovado = 2,
        SeparacaoEstoque = 3,
        NotaFiscalEmitida = 4,
        EntregueTransportadora = 5,
        EncaminhadoParaRegiao = 6,
        SaiuParaEntrega = 7,
        Entregue = 8
    }
}