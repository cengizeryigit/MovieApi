using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApi.Application.Features.CQRSDesignPaterns.Queries.MovieQueries;
using MovieApi.Application.Features.CQRSDesignPaterns.Results.MovieResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRSDesignPaterns.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler
    {
        private readonly MovieContext _context;

        public GetMovieByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetMovieByIdQueryResult> Handle(GetMovieByIdQuery query)
        {
            var value = await _context.Movies.FindAsync(query.MovieId);
            return new GetMovieByIdQueryResult
            {
                
                Title = value.Title,
                Description = value.Description,
                CoverImageUrl = value.CoverImageUrl,
                ReleaseDate = value.ReleaseDate,
                Duration = value.Duration,
                CreatedDate = value.CreatedDate,
                status = value.status,
                Rating = value.Rating,
            };
        }
    }
}
