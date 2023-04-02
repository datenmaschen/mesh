using System;

namespace Datamesh.Models
{
    public class DataDomain : IBaseEntity

    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}