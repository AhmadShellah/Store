using BL;
using Microsoft.AspNetCore.Mvc;
using Objects.Dtos.ProductDtos;

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
