using System;

namespace Datamesh.Models
{
    public class DataDomainDTO : IBaseEntity

    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}