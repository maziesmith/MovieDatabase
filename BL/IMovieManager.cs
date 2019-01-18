using System.Collections.Generic;
using MovieDatabase.BL.Domain;
using MovieDatabase.DAL;

namespace MovieDatabase.BL
{
    public interface IMovieManager
    {
         IMovieRepository GetRepository();
        IEnumerable<Media> GetAllMedia();
        Media GetMedia(int id);
        Movie GetMovie(int id);
        Series GetSeries(int id);
        void AddMovie(Movie movie);
        void AddSeries(Series s1);
        void ChangeMovie(Movie movie);
        void ChangeSeries(Series series);
        void RemoveMedia(Media media);
        IEnumerable<Media> GetMediaByTitle(string searchString);
    }
}