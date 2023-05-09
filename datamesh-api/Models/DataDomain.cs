using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datamesh.Models
{
    public class DataDomain : IBaseEntity

    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(Constants.MaxNameLength)]
        public string Key { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string NameAbbrevationLong { get; set; }
        [Required]
        public string NameAbbreviationShort { get; set; }
        [Required]
        public string SubscriptionName { get; set; }
        [Required]
        public Guid SubscriptionId { get; set; }
        [Required]
        public string DevOpsProjectName { get; set; }
        public ICollection<Dataproduct> Dataproducts { get; set; }
    }
}