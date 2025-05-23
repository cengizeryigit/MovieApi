﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPaterns.Results.MovieResults
{
    public class GetMovieQueryResult
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal Rating { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; } // Duration in minutes
        public DateTime ReleaseDate { get; set; }
        public string CreatedDate { get; set; }
        public bool status { get; set; }
    }
}
