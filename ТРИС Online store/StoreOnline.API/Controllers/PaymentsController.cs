using Microsoft.AspNetCore.Mvc;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.DTO;

namespace StoreOnline.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : Controller
    {
        private readonly IPaymentsService paymentsService;

        public PaymentsController(IPaymentsService paymentsService)
        {
            this.paymentsService = paymentsService;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreatePayment([FromBody] Payment request)
        {
            request.Id = Guid.NewGuid();

            var response = await paymentsService.CreatePayment(request);

            return StatusCode(201, response);
        }

        [HttpGet]
        public async Task<ActionResult<List<Payment>>> GetPayments()
        {
            var response = await paymentsService.GetAllPayments();

            return StatusCode(200, response);
        }

        [HttpPut]
        public async Task<ActionResult<Guid>> UpdatePayment([FromBody] Payment request)
        {
            var response = await paymentsService.UpdatePayment(request);

            return StatusCode(200, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Guid>> DeletePayment(Guid id)
        {
            var response = await paymentsService.DeletePayment(id);

            return StatusCode(200, response);
        }
    }
}