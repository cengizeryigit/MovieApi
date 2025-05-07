using MediatR;
using MovieApi.Application.Features.MediatorDesignPatern.Commands.TagCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPatern.Handlers.TagHandlers
{
    public class UpdateTagCommandHandler :IRequestHandler<UpdateTagCommand>
    {
        private readonly MovieContext _context;

        public UpdateTagCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.FindAsync(request.TagId);
            values.Title = request.Title;
            _context.Tags.Update(values);
            await _context.SaveChangesAsync();
        }
    }
    
}
