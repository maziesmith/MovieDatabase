using System.Linq;

namespace MovieDatabase.BL.Domain
{
    using System;
    using System.Collections.Generic;

    public abstract class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? ReleaseDate { get; set; } // Year
        public int? Priority { get; set; }
        public int? Rating { get; set; }
        public MediaType MediaType { get; set; }
        public bool IsPresent { get; set; }
        public DateTime? WatchDate { get; set; }

        public ICollection<ActorAct> ActorActs { get; set; }
        public ICollection<MediaGenre> MediaGenres { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}\nRelease date: {ReleaseDate}\n";
        }
    }
}