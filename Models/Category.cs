using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DependentDropdownPract.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        [NotMapped]
        public int? ProductID { get; set; }
        [NotMapped]
        public int? SubCategoryID { get; set; }

    }
}
