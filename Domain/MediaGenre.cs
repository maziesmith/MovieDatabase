namespace MovieDatabase.BL.Domain
{
    public class MediaGenre
    {
        public Genre Genre { get; set; }
        public Media Media { get; set; }
        public int GenreId { get; set; }
        public int MediaId { get; set; }
    }
}