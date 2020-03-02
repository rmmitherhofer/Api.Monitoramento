using Newtonsoft.Json;
using Api.Monitoramento.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Monitoramento.Infra.Data.ServiceExternal
{
    public class SmartAutoMatosApi : ISmartAutoMatosApi
    {
        private HttpClient _httpClient;

        public async Task<IEnumerable<HardwareMonitoramentoApi>> ChamarAPISmartAutoMatosAsync()
        {
            return await ObterTodosOsHardwaresAsync();
        }
        private async Task<IEnumerable<HardwareMonitoramentoApi>> ObterTodosOsHardwaresAsync()
        {
            try
            {
                _httpClient = new HttpClient();
                string AutoMatosId = "364093392016";
                string ChaveDeSeguranca = "NjcwRjI3Rjk4NkEyMUJBRkJGNjU1QzA5NDQ4QTVDNDU=";
                string pathAPIAutoMatos = $"https://smart.automatos.com:5005/api/getAllHardware/desktops?AutomatosId={AutoMatosId}&Securitykey={ChaveDeSeguranca}";

                HttpResponseMessage resposta = await _httpClient.GetAsync(pathAPIAutoMatos);
                resposta.EnsureSuccessStatusCode();
                var json = resposta.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<HardwareMonitoramentoApi>>(json.Result.ToString());
            }
            catch (HttpRequestException ex)
            {
                throw new HttpRequestException($"API SmartAutoMatos Indisponivel {ex.Message}", ex.InnerException);
            }
        }
    }
}
