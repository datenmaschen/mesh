using Microsoft.EntityFrameworkCore;
using Datamesh.Models.Enums;
using Datamesh.Models.Helpers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datamesh.Models
{
    [Table("Dataproduct")]
    [Index(nameof(Key), IsUnique = true)]
    public class Dataproduct : IBaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(Constants.MaxNameLength)]

        public string Name { get; set; }
        [Required]
        [MaxLength(Constants.MaxKeyLength)]

        public string Key { get; set; }
        [Required]
        public string AdGroupContributor { get; set; }
        [Required]
        public string Owner { get; set; }
        [Required]
        public string DeputyOwner { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Purpose { get; set; }
        [Required]
        [DefaultValue(DataproductStatus.New)]
        public DataproductStatus Status { get; set; }
        [Required]
        [DefaultValue(DataproductType.StandardDataproductSpark)]
        public DataproductType Type { get; set; }
        [Required]
        public int RefreshInHour { get; set; }
        [Required]
        public DataproductServiceLevelObjectiveStability ServiceLevelObjectiveStability { get; set; }
        [Required]
        public string UsageRestrictions { get; set; } // free text regarding "data category" & "confidentiality"
        [Required]
        public string ApiUrl { get; set; }
        public Guid CatalogId { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime DateCreatedAt { get; set; }
        
        [ForeignKey("DataDomain")]
        public Guid DataDomainId { get; set; }
        public DataDomain DataDomain { get; set; }

        public void SetAdGroupContributorByConvention()
        {
            string source = "Azure";
            string workload = "mesh";
            string stage = Helper.CapitalizeFirstChar(DataDomain.SubscriptionName.Split("-")[1]);
            string category = Helper.CapitalizeFirstChar(Key);
            string role = "DPC";

            AdGroupContributor = $"{source}_{workload}_{stage}_{category}_{role}";
        }
    }
}