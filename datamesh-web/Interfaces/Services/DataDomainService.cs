using datamesh_web.Models;
using datamesh_web.Helpers;
using datamesh_web.Interfaces;

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
    }
}