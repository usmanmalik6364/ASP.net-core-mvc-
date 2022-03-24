using System.ComponentModel.DataAnnotations;

namespace BookApplication.Models
{
    public class Category
    {   
        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
    }
}
