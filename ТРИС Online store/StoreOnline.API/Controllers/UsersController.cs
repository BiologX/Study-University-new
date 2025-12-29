using Microsoft.AspNetCore.Mvc;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.DTO.Requests;
using StoreOnline.Core.DTO;

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
        public async Task<ActionResult<Guid>> CreateUser([FromBody] CreateUserRequest request)
        {
            var user = Core.DTO.User.Create(
                Guid.NewGuid(),
                request.Name,
                request.Login,
                request.PasswordHash);


            var response = await usersService.CreateUser(user);

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