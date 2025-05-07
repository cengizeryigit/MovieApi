using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MovieApi.Application.Features.MediatorDesignPatern.Commands.CastCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPatern.Handlers.CastHandler
{
    public class RemoveCastCommandHandler:IRequestHandler<RemoveCastCommand>
    {
        private readonly MovieContext _context;

        public RemoveCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveCastCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.FindAsync(request.CastId);
            _context.Casts.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
    
}
