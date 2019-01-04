using System;

namespace MovieDatabase.BL.Domain
{
    public class Movie : Media
    {
        public int? Duration { get; set; }
    }
}