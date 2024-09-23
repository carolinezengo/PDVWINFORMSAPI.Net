
using FORMSAPI.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FORMSAPI.Servicos
{
    public class GerarToken
    {
        private string URI = "";
        private static string _urlBase;
        //private readonly HttpClient HttpClient;

       


        public static void GerarTokenAPI()
       {

            _urlBase = "https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1";
            var password = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImNueGVrZ3hoYnRwaW1jaWJubHhtIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTcyNjk0ODAwOSwiZXhwIjoyMDQyNTI0MDA5fQ.ppXdqflknPJ6zIBTKfSi3GnS8FMXYq7yAieahd_SlGU";


            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, _urlBase);
            request.Headers.Add("apikey", password);
            request.Headers.Add("Authorization", "Bearer " + password);
           // var result =await client.SendAsync(request);



            }

            
            

                   }



        }
                      
    


    

