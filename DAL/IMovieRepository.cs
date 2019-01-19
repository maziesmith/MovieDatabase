using System.Collections;
using System.Collections.Generic;
using MovieDatabase.BL.Domain;

namespace MovieDatabase.DAL
{
    public interface IMovieRepository
    {
        MovieDatabaseDbContext GetContext();
        IEnumerable<Media> ReadAllMedia();
        Media ReadMedia(int id);
        Movie ReadMovie(int id);
        Series ReadSeries(int id);
        void CreateMovie(Movie movie);
        void CreateSeries(Series series);
        void UpdateMovie(Movie movie);
        void UpdateSeries(Series series);
        void DeleteMedia(Media media);
        IEnumerable<Media> ReadMediaByTitle(string searchString);
        void CreateMediaGenre(Media media, IEnumerable<Genre> genres);
    }
}