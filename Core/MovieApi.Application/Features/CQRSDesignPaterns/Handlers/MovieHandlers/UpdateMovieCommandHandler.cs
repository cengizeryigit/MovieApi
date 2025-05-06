using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApi.Application.Features.CQRSDesignPaterns.Commands.MovieCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRSDesignPaterns.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _context;
        public UpdateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateMovieCommand command)
        {
            var value = await _context.Movies.FindAsync(command.MovieId);
            value.Title = command.Title;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Rating = command.Rating;
            value.Description = command.Description;
            value.Duration = command.Duration;
            value.ReleaseDate = command.ReleaseDate;
            value.CreatedDate = command.CreatedDate;
            value.status = command.status;
            _context.Movies.Update(value);
            await _context.SaveChangesAsync();
        }

    }
}
