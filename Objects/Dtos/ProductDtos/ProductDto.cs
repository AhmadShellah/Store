namespace Objects.Dtos.ProductDtos
{
    public class ProductDto : BaseEntityDto
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string? Description { get; set; }
    }
}
