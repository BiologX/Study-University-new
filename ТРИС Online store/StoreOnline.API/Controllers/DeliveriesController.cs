using Microsoft.AspNetCore.Mvc;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.Models;

namespace StoreOnline.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveriesController : Controller
    {
        private readonly IDeliveriesService deliveriesService;

        public DeliveriesController(IDeliveriesService deliveriesService)
        {
            this.deliveriesService = deliveriesService;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateDelivery([FromBody] Delivery request)
        {
            request.Id = Guid.NewGuid();

            var response = await deliveriesService.CreateDelivery(request);

            return StatusCode(201, response);
        }

        [HttpGet]
        public async Task<ActionResult<List<Delivery>>> GetDeliveries()
        {
            var response = await deliveriesService.GetAllDeliveries();

            return StatusCode(200, response);
        }

        [HttpPut]
        public async Task<ActionResult<Guid>> UpdateDelivery([FromBody] Delivery request)
        {
            var delivery = Delivery.Create(
                request.Id,
                request.Address,
                request.Status,
                request.CreatedDate,
                request.OrderId
            );

            var response = await deliveriesService.UpdateDelivery(delivery);

            return StatusCode(200, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Guid>> DeleteDelivery(Guid id)
        {
            var response = await deliveriesService.DeleteDelivery(id);

            return StatusCode(200, response);
        }
    }
}