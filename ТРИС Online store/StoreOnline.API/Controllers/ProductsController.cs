using Microsoft.AspNetCore.Mvc;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.DTO;

namespace StoreOnline.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateProduct([FromBody] Product request)
        {
            request.Id = Guid.NewGuid();

            var response = await productsService.CreateProduct(request);

            return StatusCode(201, response);
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var response = await productsService.GetAllProducts();

            return StatusCode(200, response);
        }

        [HttpPut]
        public async Task<ActionResult<Guid>> UpdateProduct([FromBody] Product request)
        {
            var response = await productsService.UpdateProduct(request);

            return StatusCode(200, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Guid>> DeleteProduct(Guid id)
        {
            var response = await productsService.DeleteProduct(id);

            return StatusCode(200, response);
        }
    }
}