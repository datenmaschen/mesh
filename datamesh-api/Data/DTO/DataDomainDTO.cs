using System;
using Datamesh.Models;

namespace Datamesh.Data.DTO
{
    public class DataDomainDTO : DataDomain

    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}