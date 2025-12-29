using Microsoft.AspNetCore.Mvc;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.Models;

namespace StoreOnline.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateCategory([FromBody] Category request)
        {
            request.Id = Guid.NewGuid();

            var response = await categoriesService.CreateCategory(request);

            return StatusCode(201, response);
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            var response = await categoriesService.GetAllCategories();

            return StatusCode(200, response);
        }

        [HttpPut]
        public async Task<ActionResult<Guid>> UpdateCategory([FromBody] Category request)
        {
            var response = await categoriesService.UpdateCategory(request);

            return StatusCode(200, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Guid>> DeleteCategory(Guid id)
        {
            var response = await categoriesService.DeleteCategory(id);

            return StatusCode(200, response);
        }
    }
}