using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MovieApi.Application.Features.MediatorDesignPatern.Results.TagResults;

namespace MovieApi.Application.Features.MediatorDesignPatern.Queries.TagQueries
{
    public class GetTagByIdQuery :IRequest<GetTagByIdQueryResult>
    {
        public int TagId { get; set; }
        public GetTagByIdQuery(int tagId)
        {
            TagId = tagId;
        }
    }
   
}
