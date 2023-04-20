using datamesh_web.Models;
using datamesh_web.Helpers;
using datamesh_web.Interfaces;

namespace datamesh_web.Interfaces.Services
{
    public class DataproductService : IDataproductService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/DataproductItems";

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
    }
}