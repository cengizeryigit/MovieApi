using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.MediatorDesignPatern.Queries.CastQueries;
using MovieApi.Application.Features.MediatorDesignPatern.Results.CastResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPatern.Handlers.CastHandler
{
    public class GetCastQueryHandler : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
    {
        private readonly MovieContext _context;

        public GetCastQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.ToListAsync();
            return values.Select(x => new GetCastQueryResult
            {
                CastId = x.CastId,
                Name = x.Name,
                Surname = x.Surname,
                Title = x.Title,
                ImageUrl = x.ImageUrl,
                Overview = x.Overview,
                Biography = x.Biography
            }).ToList();
        }
    }
}
