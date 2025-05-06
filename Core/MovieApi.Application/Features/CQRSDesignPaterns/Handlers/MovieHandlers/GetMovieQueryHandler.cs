using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRSDesignPaterns.Results.MovieResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRSDesignPaterns.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler
    {
        private readonly MovieContext _context;
        public GetMovieQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<GetMovieQueryResult>> Handle()
        {
            var values = await _context.Movies.ToListAsync();
            return values.Select(x => new GetMovieQueryResult
            {
                MovieId = x.MovieId,
                Title = x.Title,
                Description = x.Description,
                CoverImageUrl = x.CoverImageUrl,
                ReleaseDate = x.ReleaseDate,
                Duration = x.Duration,
                CreatedDate = x.CreatedDate,
                status = x.status,
                Rating = x.Rating,
            }).ToList();
        }
    }
}
