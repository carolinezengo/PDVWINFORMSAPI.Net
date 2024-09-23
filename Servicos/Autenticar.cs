using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net;

using System.Runtime.Intrinsics.Arm;
using Newtonsoft.Json.Linq;
using FORMSAPI.Entidades;

namespace FORMSAPI.Servicos
{
    public class Autenticar
    {
     
       

        public static HttpResponseMessage AutenticarBanco()
        {
         
            using (var client = new HttpClient())
            {
                
                // Envio da requisição a fim de autenticar
                // e obter o token de acesso

                
                string _urlBase = AcessoTokenEUrl.URl();
                var password = AcessoTokenEUrl.PASSWORD();
                string urlbase = _urlBase;



                var request = new HttpRequestMessage(HttpMethod.Get, _urlBase);
                request.Headers.Add("apikey", password);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", password);
                var responseMensagem =  client.SendAsync(request);
                
                var responseResult= responseMensagem.Result;

                var requestMenssagem = responseResult.RequestMessage;
                var content = requestMenssagem.Headers.ToString();
               
 
                if (responseResult.IsSuccessStatusCode)
                {
                   

                    return responseResult;
                }
                else
                {
                    return null;
                }
               
              
            }
}    }   }         