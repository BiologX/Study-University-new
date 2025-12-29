using Microsoft.AspNetCore.Mvc;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.Models;

namespace StoreOnline.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BasketsController : Controller
    {
        private readonly IBasketsService basketsService;

        public BasketsController(IBasketsService basketsService)
        {
            this.basketsService = basketsService;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> AddToBasket([FromBody] Basket request)
        {
            request.Id = Guid.NewGuid();

            var response = await basketsService.AddToBasket(request);

            return StatusCode(201, response);
        }

        [HttpGet]
        public async Task<ActionResult<List<Basket>>> GetAllBasketItems()
        {
            var response = await basketsService.GetAllBasketItems();

            return StatusCode(200, response);
        }

        [HttpPut]
        public async Task<ActionResult<Guid>> UpdateBasketItem([FromBody] Basket request)
        {
            var response = await basketsService.UpdateBasketItem(request);

            return StatusCode(200, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Guid>> RemoveFromBasket(Guid id)
        {
            var response = await basketsService.RemoveFromBasket(id);

            return StatusCode(200, response);
        }
    }
}