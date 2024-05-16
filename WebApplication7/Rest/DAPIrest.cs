using WebApplication7.Dtos;
using WebApplication7.Interfaces;
using WebApplication7.Models;
using System.Text.Json;
using System.Dynamic;

namespace WebApplication7.Rest
{

    public class DAPIrest : IDAPI
    {
        public async Task<ResponseGenerico<List<PEPModel>>> BuscarPEPPorCpf(string Cpf)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                $"https://api.portaldatransparencia.gov.br/api-de-dados/peps?cpf={Cpf}&pagina=1");
            request.Headers.Add("chave-api-dados", "e8dfc881692cc6dd581b92be898137ff");
            var response = new ResponseGenerico<List<PEPModel>>();
            using (var client = new HttpClient())
            {
                var responseDAPI = await client.SendAsync(request);
                var contentResp = await responseDAPI.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<PEPModel>>(contentResp);

                if (responseDAPI.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseDAPI.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseDAPI.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }

            }

            return response;
        }

        public async Task<ResponseGenerico<List<CepimModel>>> BuscarCepimPorCNPJ(string CNPJ)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                $"https://api.portaldatransparencia.gov.br/api-de-dados/cepim?cnpjSancionado={CNPJ}&pagina=1");
            request.Headers.Add("chave-api-dados", "e8dfc881692cc6dd581b92be898137ff");
            var response = new ResponseGenerico<List<CepimModel>>();
            using (var client = new HttpClient())
            {
                var responseDAPI = await client.SendAsync(request);
                var contentResp = await responseDAPI.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<CepimModel>>(contentResp);

                if (responseDAPI.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseDAPI.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseDAPI.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }

            }

            return response;        
        }
    }
}
        
    

