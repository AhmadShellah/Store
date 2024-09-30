using System.ComponentModel.DataAnnotations;

namespace Objects.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal? Price { get; set; }

        public string? Description { get; set; }
    }
}
