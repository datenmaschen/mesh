using System.ComponentModel.DataAnnotations;

namespace datamesh_web.Models
{
    public class DataDomainModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is Required.")]
        [StringLength(40, ErrorMessage = "Name length can't be more than 40.")]
        [Display(Name = "Data Domain Name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Key is Required.")]
        [StringLength(20, ErrorMessage = "Key length can't be more than 20.")]
        [Display(Name = "Data Domain Key")]
        public string Key { get; set; }
        [Required(ErrorMessage = "NameAbbrevationLong is Required.")]
        [Display(Name = "Abbrevation Long Name")]
        public string NameAbbrevationLong { get; set; }
        [Required(ErrorMessage = "NameAbbreviationShort is Required.")]
        [Display(Name = "Abbrevation Short Name")]
        public string NameAbbreviationShort { get; set; }
        [Required(ErrorMessage = "SubscriptionName is Required.")]
        [Display(Name = "Subscription Name")]
        public string SubscriptionName { get; set; }
        [Required(ErrorMessage = "SubscriptionId is Required.")]
        [Display(Name = "Subscription Id")]
        public Guid SubscriptionId { get; set; }
        [Required(ErrorMessage = "DevOpsProjectName is Required.")]
        [Display(Name = "DevOps Project")]
        public string DevOpsProjectName { get; set; }
    }
}