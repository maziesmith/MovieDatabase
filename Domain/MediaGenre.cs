using System.ComponentModel.DataAnnotations;

namespace MovieDatabase.BL.Domain
{
    public class MediaGenre
    {
        [Key]
        public int Id { get; set; }
        public Genre Genre { get; set; }
        public Media Media { get; set; }
    }
}