using System.Collections.Generic;
using MovieDatabase.BL.Domain;

namespace MovieDatabase.BL
{
    public interface IMovieManager
    {
        IEnumerable<Media> GetAllMedia();
        Media GetMedia(int id);
        Movie GetMovie(int id);
        Series GetSeries(int id);
        void AddMovie(Movie movie);
        void AddSeries(Series s1);
        void ChangeMovie(Movie movie);
        void ChangeSeries(Series series);
    }
}