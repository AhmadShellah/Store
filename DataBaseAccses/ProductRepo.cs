namespace DataBaseAccses
{
    public class ProductRepo
    {
        private readonly static List<Product> _products = new();

        public List<Product> GetAll()
        {
            var result = _products.Where(s => s.IsDeleted != true).ToList();

            return result;
        }

        public Product Create(Product inputFromUser)
        {
            _products.Add(inputFromUser);

            return _products.FirstOrDefault(s => inputFromUser.Id == s.Id);
        }

        public void Delete(Guid id)
        {
            var result = _products.FirstOrDefault(s => s.Id == id);
            if (result is not null)
            {
                result.SetIsDeleted();
            }
        }
    }
}
