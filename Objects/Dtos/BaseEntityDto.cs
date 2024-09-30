namespace Objects.Dtos
{
    public abstract class BaseEntityDto
    {
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
