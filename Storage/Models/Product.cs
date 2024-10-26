using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Range(1, 30000)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public DateTime Orderdate { get; set; }

        [Required]
        public string Category { get; set; }

        [StringLength(10)]
        public string Shelf { get; set; }

        [Range(0, 1000)]
        public int Count { get; set; }
        
        [StringLength(500)]
        public string Description { get; set; }
    }
}
