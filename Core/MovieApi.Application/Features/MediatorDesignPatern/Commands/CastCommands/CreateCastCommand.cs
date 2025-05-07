using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace MovieApi.Application.Features.MediatorDesignPatern.Commands.CastCommands
{
    public class CreateCastCommand:IRequest
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string? Overview { get; set; } // Nullable property for overview
        public string? Biography { get; set; }
    }
}
