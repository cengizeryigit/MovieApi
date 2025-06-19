using Microsoft.AspNetCore.Identity;
using MovieApi.Application.Features.CQRSDesignPaterns.Commands.UserRegisterCommands;
using MovieApi.Persistence.Context;
using MovieApi.Persistence.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPaterns.Handlers.UserRegisterHandlers
{
    public class CreateUserRegisterCommandHandler
    {
        private readonly MovieContext _context;
        private readonly UserManager<AppUser> _userManger;

        public CreateUserRegisterCommandHandler(MovieContext context, UserManager<AppUser> userManger)
        {
            _context = context;
            _userManger = userManger;
        }

        public async Task Handle(CreateUserRegisterCommand command)
        {
            var user = new AppUser()
            {
                Name = command.Name,
                Surname = command.Surname,
                UserName = command.Username,
                Email = command.Email

            };

            await _userManger.CreateAsync(user, command.Password);
        }
    }
}
