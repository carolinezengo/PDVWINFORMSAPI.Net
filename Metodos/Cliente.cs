
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
using Newtonsoft.Json;
using System.Text;

namespace FORMSAPI.Metodos

{
    public class Cliente : ICliente
    {
        



        public async Task<bool> Apagar(int codigo)
        {
            using (var client = new HttpClient())
            {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);

                var response = await client.DeleteAsync($"https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/Cliente?Codigo=eq.{codigo}");
                var responseText = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }
        public async Task<bool> Atualizar(ClienteEntindade cliente, int codigo)
        {
            using (var client = new HttpClient())
            {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);

                var content = new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/Cliente?Codigo=eq.{codigo}", content);
                var responseText = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public async Task<ClienteEntindade> BuscarPorId(int codigo)
        {
          
            using (var client = new HttpClient())
            {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);


                using (var response = await client.GetAsync($"https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/Cliente?Codigo=eq.{codigo}"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        JsonSerializerOptions options = new JsonSerializerOptions
                        {
                            IncludeFields = true,
                            PropertyNameCaseInsensitive = true
                        };


                       ClienteEntindade clientes = JsonSerializer.Deserialize<ClienteEntindade>(content, options);
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

        public async Task<bool> Incluir(ClienteEntindade cliente)
        {


            using (var client = new HttpClient())
            {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);

                var content = new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/Cliente", content);
                var responseText = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }



        }



        public async Task<List<ClienteEntindade>> Todos()
        {
          
                using (var client = new HttpClient())
                {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);

               
                    using (var response = await client.GetAsync($"https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/Cliente"))
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
    
    

