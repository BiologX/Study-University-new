using Microsoft.AspNetCore.Mvc;
using StoreOnline.API.Contracts.Users.Request;
using StoreOnline.API.Contracts.Users.Response;
using StoreOnline.Core.Abstractions.Services;

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
            var user = Core.Models.User.Create(
                Guid.NewGuid(),
                request.Name,
                request.Login,
                request.Password
                );

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
        public async Task<ActionResult<Guid>> UpdateUser([FromBody] UpdateUserRequest request)
        {
            var response = await usersService.UpdateUser(
                request.Id,
                request.Name,
                request.Login,
                request.Password);

            return StatusCode(201, response);
        }
    }
}