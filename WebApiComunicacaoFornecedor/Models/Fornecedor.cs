using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiComunicacaoFornecedor.Models
{
    [Table("Fornecedores")]
    public class Fornecedor
    {
        public int fornecedorId { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string email { get; set; }

    }
}