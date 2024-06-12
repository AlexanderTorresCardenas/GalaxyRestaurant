using Microsoft.AspNetCore.Mvc;
using Restaurant.Services;
using Restaurant.Shared.Request;

namespace Restaurant.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        protected IUserService _userService;
        public UsuariosController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTORequest request)
        {
            var response = await _userService.LoginAsync(request);

            return Ok(response);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegistrarUsuarioDTO request)
        {
            var response = await _userService.RegisterAsyn(request);

            return Ok(response);
        }

    }
}
