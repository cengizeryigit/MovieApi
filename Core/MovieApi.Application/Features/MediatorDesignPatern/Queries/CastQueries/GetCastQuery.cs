using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MovieApi.Application.Features.MediatorDesignPatern.Results.CastResults;

namespace MovieApi.Application.Features.MediatorDesignPatern.Queries.CastQueries
{
    public class GetCastQuery:IRequest<List<GetCastQueryResult>>
    {
    }
}
