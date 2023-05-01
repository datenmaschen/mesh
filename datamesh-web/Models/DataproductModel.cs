using System.ComponentModel.DataAnnotations;

namespace datamesh_web.Models
{
    public class DataproductModel
    {
        public Guid Id { get; set; }
        [Display(Name = "Dataproduct Name")]
        public string? Name { get; set; }
        [Display(Name = "Dataproduct Key")]
        public string Key { get; set; }
    }
}