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
    public class Fornecedor : IFornecedor
    {
        public async Task<bool> Apagar(int codigo)
        {
            using (var client = new HttpClient())
            {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);

                var response = await client.DeleteAsync($"https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/Fornecedor?Codigo=eq.{codigo}");
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

        public async Task<bool> Atualizar(FornecedorEntidade fornecedor, int codigo)
        {
            using (var client = new HttpClient())
            {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);

                var content = new StringContent(JsonConvert.SerializeObject(fornecedor), Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/Fornecedor?Codigo=eq.{codigo}", content);
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

        public FornecedorEntidade BuscarPorId(int codigo)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Incluir(FornecedorEntidade fornecedor)
        {
            using (var client = new HttpClient())
            {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);

                var content = new StringContent(JsonConvert.SerializeObject(fornecedor), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/Fornecedor", content);
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

        public async Task<List<FornecedorEntidade>> Todos()
        {
            using (var client = new HttpClient())
            {
                AutorizacaoAPI.GetHeaderTokenAuthorization(client);


                using (var response = await client.GetAsync("https://cnxekgxhbtpimcibnlxm.supabase.co/rest/v1/Fornecedor"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        JsonSerializerOptions options = new JsonSerializerOptions
                        {
                            IncludeFields = true,
                            PropertyNameCaseInsensitive = true
                        };


                        List<FornecedorEntidade> fornecedor = JsonSerializer.Deserialize<List<FornecedorEntidade>>(content, options);
                        return fornecedor;
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
