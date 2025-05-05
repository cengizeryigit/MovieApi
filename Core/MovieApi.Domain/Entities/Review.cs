using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Domain.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewComment { get; set; }
        public int UserRating { get; set; } // User rating out of 10
        public DateTime ReviewDate { get; set; }
        public bool Status { get; set; } // Indicates if the review is active or inactive
    }
}
