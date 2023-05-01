using datamesh_web.Models;
using datamesh_web.Helpers;
using datamesh_web.Interfaces;
using Newtonsoft.Json;
using System.Text;

namespace datamesh_web.Interfaces.Services
{
    public class DataproductService : IDataproductService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/Dataproduct";

        public DataproductService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<DataproductModel>> Find()
        {
            var response = await _client.GetAsync(BasePath);

            return await response.ReadContentAsync<List<DataproductModel>>();
        }

        public async Task<DataproductModel> FindById(Guid id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");

            return await response.ReadContentAsync<DataproductModel>();
        }

        public async Task Add(DataproductModel dataproduct)
        {
            string json = JsonConvert.SerializeObject(dataproduct, Formatting.Indented);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(BasePath, data);

            response.EnsureSuccessStatusCode();
        }
    }
}