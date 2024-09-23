using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using FORMSAPI.Entidades;



namespace FORMSAPI.Servicos
{
   public class AutorizacaoAPI 
    {

        public static void GetHeaderTokenAuthorization(HttpClient client) 

        {
            string password = AcessoTokenEUrl.PASSWORD();

           
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("apikey",password );
            client.DefaultRequestHeaders.Accept.Add(
           
            new MediaTypeWithQualityHeaderValue("application/json"));
            

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", password);
        }
    }
}

