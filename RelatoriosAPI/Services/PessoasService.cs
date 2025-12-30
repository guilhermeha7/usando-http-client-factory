using RelatoriosAPI.Models;
using System.Text.Json;

namespace RelatoriosAPI.Services
{
    public class PessoasService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PessoasService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<Pessoa>> ObterPessoasAsync()
        {
            var client = _httpClientFactory.CreateClient("PessoasAPI"); //Cria o canal de comunicação com PessoasAPI
            
            var response = await client.GetAsync("api/pessoas"); //Realiza uma requisição para a API Pessoas e reotrna a resposta completa (com body e status)

            var json = await response.Content.ReadAsStringAsync(); //Pega o body da response que está em json

            return JsonSerializer.Deserialize<List<Pessoa>>(json); //Converte o json para a classe List<Pessoa>
        }
    }
}
