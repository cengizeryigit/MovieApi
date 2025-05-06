using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApi.Application.Features.CQRSDesignPaterns.Commands.MovieCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRSDesignPaterns.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _context;
        public CreateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void handle(CreateMovieCommand command)
        {
            _context.Movies.Add(new Movie
            {
                Title = command.Title,
                CoverImageUrl = command.CoverImageUrl,
                Rating = command.Rating,
                Description = command.Description,
                Duration = command.Duration,
                ReleaseDate = command.ReleaseDate,
                CreatedDate = command.CreatedDate,
                status = command.status,
            });

            await _context.SaveChangesAsync();
        }
    }
}
