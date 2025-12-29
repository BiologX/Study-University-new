using Microsoft.AspNetCore.Mvc;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.Models;

namespace StoreOnline.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateUser([FromBody] User request)
        {
            request.Id = Guid.NewGuid();
            
            var response = await usersService.CreateUser(request);

            return StatusCode(201, response);
        }

        [HttpGet]
        public async Task<ActionResult<Guid>> GetUsers()
        {
            var response = await usersService.GetAllUsers();

            return StatusCode(201, response);
        }

        [HttpPut]
        public async Task<ActionResult<Guid>> UpdateUser([FromBody] User request)
        {
            var response = await usersService.UpdateUser(request);

            return StatusCode(201, response);
        }

        [HttpDelete]
        public async Task<ActionResult<Guid>> DeleteUser([FromBody] Guid id)
        {
            var response = await usersService.DeleteUser(id);

            return StatusCode(201, response);
        }
    }
}