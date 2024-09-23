using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace FORMSAPI.Entidades
{
   public  class AcessoTokenEUrl
    {

        public static string Url { get; set; }


        public static  string Password { get; set; }
          
            public static string URl()
            {
                Url = "https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/";
                 return Url;
             }

        public static string PASSWORD()
        {
             Password = "";
            return Password;
        }














    }      
       
}
