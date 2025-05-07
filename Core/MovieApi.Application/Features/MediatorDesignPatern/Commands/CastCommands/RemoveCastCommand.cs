using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace MovieApi.Application.Features.MediatorDesignPatern.Commands.CastCommands
{
    internal class RemoveCastCommand:IRequest
    {
        public RemoveCastCommand(int castId)
        {
            CastId = castId;
        }

        public int CastId { get; set; }

    }
}
