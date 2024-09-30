using System.ComponentModel.DataAnnotations;

namespace DataBaseAccses
{
    public class Product : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; } = decimal.Zero;
    }
}
