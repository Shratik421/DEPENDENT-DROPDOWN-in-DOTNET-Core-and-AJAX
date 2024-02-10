using System.ComponentModel.DataAnnotations;

namespace DependentDropdownPract.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }
        public int? CategoryID { get; set; }
        public String? SubCategoryName { get; set; }
    }
}
