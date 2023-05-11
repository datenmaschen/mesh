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
        [Required(ErrorMessage = "Name Abbreviation Long is Required.")]
        [Display(Name = "Abbreviation Long")]
        public string NameAbbreviationLong { get; set; }
        [Required(ErrorMessage = "Name Abbreviation Short is Required.")]
        [StringLength(4, ErrorMessage = "Abbreviation Short length can't be more than 4.")]
        [Display(Name = "Abbrevation Short")]
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