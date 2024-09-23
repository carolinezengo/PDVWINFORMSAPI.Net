
using System.Collections.Generic;
using System.Net.Http;

using System.Threading.Tasks;
using System;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Security.Policy;
using System.Configuration;
using FORMSAPI.Entidades;
using FORMSAPI.Interfaces;

using FORMSAPI.Servicos;

namespace FORMSAPI.Metodos

{
    public class Cliente : ICliente
    {
        private static string url;
        private static string senha;

        string parametro = "Cliente";
          
        

        public async void Apagar(ClienteEntindade cliente)
        {
         


            throw new System.NotImplementedException();
        }

        public void Atualizar(ClienteEntindade cliente)
        {
            throw new System.NotImplementedException();
        }

        public ClienteEntindade BuscarPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Incluir(ClienteEntindade cliente)
        {
           


               

            
        }



        public async Task<List<ClienteEntindade>> Todos()
        {
            url = AcessoTokenEUrl.Url;
            string urlcompleto = url + parametro;
                using (var client = new HttpClient())
                {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);

               
                    using (var response = await client.GetAsync((urlcompleto)))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var content = await response.Content.ReadAsStringAsync();
                            JsonSerializerOptions options = new JsonSerializerOptions
                            {
                                IncludeFields = true,
                                PropertyNameCaseInsensitive = true
                            };


                            List<ClienteEntindade> clientes = JsonSerializer.Deserialize<List<ClienteEntindade>>(content, options);
                            return clientes;
                        }
                        else
                        {
                            throw new Exception("Não foi possível obter o Cliente: " + response.StatusCode);
                        }
                
                    
                    }


                    return null;

                }
                
                

            }
        }
    }
    
    

