using System.Collections;
using System.Collections.Generic;

namespace MovieDatabase.BL.Domain
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public ICollection<MediaGenre> MediaGenres { get; set; }
    }
}