using datamesh_web.Models;

namespace datamesh_web.Interfaces
{
    public interface IDataproductService
    {
        Task<IEnumerable<DataproductModel>> Find();
        Task<DataproductModel> FindById(Guid id);
        Task Add(DataproductModel dataproduct);
    }
}