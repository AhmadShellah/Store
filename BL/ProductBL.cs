using DataBaseAccses;
using Objects.Dtos.ProductDtos;

namespace BL
{
    //Crud
    public class ProductBL
    {
        private readonly ProductRepo _productRepo;

        public ProductBL()
        {
            _productRepo = new ProductRepo();
        }

        public List<ProductDto> GetAll(string? name = null)
        {
            var result = _productRepo.GetAll();

            if (!string.IsNullOrEmpty(name))
            {
                result = result.Where(s => s.Name.Contains(name)).ToList();
            }

            var finalReuslt = result.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                CreationDate = p.CreationDate,
            }).OrderByDescending(c => c.CreationDate).ToList();

            return finalReuslt;
        }

        public List<ProductDto> GetAll()
        {
            var result = _productRepo.GetAll()
                        .Select(p => new ProductDto
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Price = p.Price,
                            Description = p.Description,
                            CreationDate = p.CreationDate,
                        }).OrderByDescending(c => c.CreationDate).ToList();

            return result;

            //var result = _products.Where(s => s.IsDeleted != true)
            //.Select(p => new ProductDto
            //{
            //    Id = p.Id,
            //    Name = p.Name,
            //    Price = p.Price,
            //    Description = p.Description,
            //    CreationDate = p.CreationDate,
            //}).OrderByDescending(c=> c.CreationDate).ToList();

            //return result;
        }

        public ProductDto Create(CreateProductDto inputFromUser)
        {
            var insertToDataBase = new Product()
            {
                Name = inputFromUser.Name,
                Price = inputFromUser.Price.Value,
                Description = inputFromUser.Description,
            };

            var afterInsert = _productRepo.Create(insertToDataBase);

            return new ProductDto()
            {
                Id = afterInsert.Id,
                Name = afterInsert.Name,
                Price = afterInsert.Price,
                Description = afterInsert.Description,
                CreationDate = afterInsert.CreationDate,
            };

            //var insertToDataBase = new Product()
            //{
            //    Name = inputFromUser.Name,
            //    Price = inputFromUser.Price.Value,
            //    Description = inputFromUser.Description,
            //};

            //_products.Add(insertToDataBase);

            //return new ProductDto()
            //{
            //    Id = insertToDataBase.Id,
            //    Name = inputFromUser.Name,
            //    Price = insertToDataBase.Price,
            //    Description = insertToDataBase.Description,
            //    CreationDate = insertToDataBase.CreationDate,
            //};
        }

        public void Delete(Guid id)
        {
            _productRepo.Delete(id);
        }

    }
}
