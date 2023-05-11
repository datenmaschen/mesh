using Datamesh.Models.Enums;
using Datamesh.Models;

namespace Datamesh.Data.Dto
{
    public class DataproductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public DataproductType Type { get; set; }
        public string Owner { get; set; }
        public string DeputyOwner { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public Guid DataDomainId { get; set; }
    }
}