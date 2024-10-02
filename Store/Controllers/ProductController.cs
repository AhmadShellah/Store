using BL;
using Microsoft.AspNetCore.Mvc;
using Objects.Dtos.ProductDtos;
using Objects.Models;

namespace Store.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductBL _productBL;

        public ProductsController()
        {
            _productBL = new ProductBL();
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_productBL.GetAll());
        }

        [HttpGet]
        public ActionResult SearchByName(string? name = null)
        {
            return Ok(_productBL.GetAll(name));
        }

        [HttpPost]
        public ActionResult CreateModel(ProductDto inputFromUser)
        {
            var afterMapping = new ProductModel()
            {
                Photo = "Hi",
                Id = inputFromUser.Id,
                Name = inputFromUser.Name,
                Description = inputFromUser.Description,
                //CreationDate = inputFromUser.CreationDate,
            };

            var result = _productBL.Create(afterMapping);

            var afterMappingProductDto = new ProductDto()
            {
                Id = result.Id,
                Name = result.Name,
                Photo = result.Photo,
                Description = result.Description,
                //CreationDate = result.CreationDate,
            };

            return Ok(afterMappingProductDto);
        }

        [HttpPost]
        public ActionResult Create(CreateProductDto inputFromUser)
        {
            var result = _productBL.Create(inputFromUser);

            return Ok(result);
        }

        [HttpDelete]
        public ActionResult Delete(Guid id)
        {
            _productBL.Delete(id);

            return Ok();
        }
    }
}
