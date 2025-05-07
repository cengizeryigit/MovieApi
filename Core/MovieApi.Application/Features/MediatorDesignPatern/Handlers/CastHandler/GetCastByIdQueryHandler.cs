using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MovieApi.Application.Features.MediatorDesignPatern.Queries.CastQueries;
using MovieApi.Application.Features.MediatorDesignPatern.Results.CastResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPatern.Handlers.CastHandler
{
    public class GetCastByIdQueryHandler : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>
    {
        private readonly MovieContext _context;

        public GetCastByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.FindAsync(request.CastId);
            return new GetCastByIdQueryResult
            {
                CastId = values.CastId,
                Name = values.Name,
                Surname = values.Surname,
                Title = values.Title,
                ImageUrl = values.ImageUrl,
                Overview = values.Overview,
                Biography = values.Biography
            };
        }
    }

}
