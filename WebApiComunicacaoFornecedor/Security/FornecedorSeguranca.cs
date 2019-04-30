using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using WebApiComunicacaoFornecedor.Models.EF;

namespace WebApiComunicacaoFornecedor.Security
{
    public class FornecedorSeguranca
    {
        public static bool Login(string login, string senha)
        {
            using (var ctx = new DropShippingContext())
            {
                return ctx.Fornecedores.Any(user =>
               user.login.Equals(login, StringComparison.OrdinalIgnoreCase)
               && user.senha == senha);
            }
        }

        public string CalculateMD5Hash(string input)
        {
            // Calcular o Hash
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // Converter byte array para string hexadecimal
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}