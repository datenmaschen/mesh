using datamesh_web.Models;
using datamesh_web.Helpers;
using datamesh_web.Interfaces;
using Newtonsoft.Json;
using System.Text;

namespace datamesh_web.Interfaces.Services
{
    public class DataDomainService : IDataDomainService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/DataDomainItems";

        public DataDomainService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<DataDomainModel>> Find()
        {
            var response = await _client.GetAsync(BasePath);

            return await response.ReadContentAsync<List<DataDomainModel>>();
        }

        public async Task<DataDomainModel> FindById(Guid id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");

            return await response.ReadContentAsync<DataDomainModel>();
        }

        public async Task add(DataDomainModel datadomain)
        {
            string json = JsonConvert.SerializeObject(datadomain, Formatting.Indented);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(BasePath, data);

            response.EnsureSuccessStatusCode();
        }
    }
}