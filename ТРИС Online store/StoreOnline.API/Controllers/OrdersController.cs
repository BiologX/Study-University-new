using Microsoft.AspNetCore.Mvc;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.Models;

namespace StoreOnline.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly IOrdersService ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateOrder([FromBody] Order request)
        {
            request.Id = Guid.NewGuid();

            var response = await ordersService.CreateOrder(request);

            return StatusCode(201, response);
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetOrders()
        {
            var response = await ordersService.GetAllOrders();

            return StatusCode(200, response);
        }

        [HttpPut]
        public async Task<ActionResult<Guid>> UpdateOrder([FromBody] Order request)
        {
            var order = Order.Create(
                request.Id,
                request.Quantity,
                request.TotalPrice,
                request.Status,
                request.CreatedDate,
                request.ProductId,
                request.UserId
            );

            var response = await ordersService.UpdateOrder(order);

            return StatusCode(200, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Guid>> DeleteOrder(Guid id)
        {
            var response = await ordersService.DeleteOrder(id);

            return StatusCode(200, response);
        }
    }
}