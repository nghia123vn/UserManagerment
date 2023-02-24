using Microsoft.AspNetCore.Mvc;
using UserInfrastructure.Repositories;
using UserInfrastructure.Services;
namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("Login/{name}")]
        public void Login(string name, string password)
        {
            IUserRepository userRepository = new UserRepository();
            var check = userRepository.login(name, password);
        }

        [HttpGet("List")]
        public void ListUser()
        {
            IUserService userService = new UserService();
            userService.ListUser().ToList();

        }

    }
}
