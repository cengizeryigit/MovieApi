using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.CQRSDesignPaterns.Commands.UserRegisterCommands;
using MovieApi.Application.Features.CQRSDesignPaterns.Handlers.UserRegisterHandlers;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly CreateUserRegisterCommandHandler _createUserRegisterCommandHandler;

        public RegistersController(CreateUserRegisterCommandHandler createUserRegisterCommandHandler)
        {
            _createUserRegisterCommandHandler = createUserRegisterCommandHandler;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserRegister(CreateUserRegisterCommand command)
        {
            await _createUserRegisterCommandHandler.Handle(command);
            return Ok("User registered successfully." );
        }
    }
}
