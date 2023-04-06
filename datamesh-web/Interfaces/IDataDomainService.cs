using datamesh_web.Models;

namespace datamesh_web.Interfaces
{
    public interface IDataDomainService
    {
        Task<IEnumerable<DataDomainModel>> Find();
    }
}