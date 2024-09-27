using FORMSAPI.Entidades;
using FORMSAPI.Interfaces;
using FORMSAPI.Servicos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace FORMSAPI.Metodos
{
    public class Produto : IProduto
    {
        public async Task<bool> Apagar(int codigo)
        {
            using (var client = new HttpClient())
            {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);

                var response = await client.DeleteAsync($"https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/Produto?Codigo=eq.{codigo}");
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

        public async Task<bool> Atualizar(ProdutoEntidade produto, int codigo)
        {
            using (var client = new HttpClient())
            {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);

                var content = new StringContent(JsonConvert.SerializeObject(produto), Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/Produto?Codigo=eq.{codigo}", content);
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

        public ProdutoEntidade BuscarPorId(int codigo)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Incluir(ProdutoEntidade produto)
        {
            using (var client = new HttpClient())
            {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);

                var content = new StringContent(JsonConvert.SerializeObject(produto), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/Produto", content);
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

        public async Task<List<ProdutoEntidade>> Todos()
        {
            using (var client = new HttpClient())
            {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);


                using (var response = await client.GetAsync("https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/Produto"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        JsonSerializerOptions options = new JsonSerializerOptions
                        {
                            IncludeFields = true,
                            PropertyNameCaseInsensitive = true
                        };


                      List< ProdutoEntidade> produtos = JsonSerializer.Deserialize<List<ProdutoEntidade>>(content, options);
                        return produtos;
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
