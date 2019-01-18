using System.Collections.Generic;
using MovieDatabase.BL.Domain;
using MovieDatabase.DAL;

namespace MovieDatabase.BL
{
    public class MovieManager : IMovieManager
    {
        private readonly IMovieRepository _movieRepository;

        public MovieManager()
        {
            _movieRepository = new MovieRepository();
        }

        public IMovieRepository GetRepository()
        {
            return _movieRepository;
        }

        public IEnumerable<Media> GetAllMedia()
        {
            return _movieRepository.ReadAllMedia();
        }

        public Media GetMedia(int id)
        {
            return _movieRepository.ReadMedia(id);
        }


        public Movie GetMovie(int id)
        {
            return _movieRepository.ReadMovie(id);
        }

        public Series GetSeries(int id)
        {
            return _movieRepository.ReadSeries(id);
        }

        public void AddMovie(Movie movie)
        {
            _movieRepository.CreateMovie(movie);
        }

        public void AddSeries(Series series)
        {
            _movieRepository.CreateSeries(series);
        }

        public void ChangeMovie(Movie movie)
        {
            _movieRepository.UpdateMovie(movie);
        }

        public void ChangeSeries(Series series)
        {
            _movieRepository.UpdateSeries(series);
        }

        public void RemoveMedia(Media media)
        {
            _movieRepository.DeleteMedia(media);
        }

        public IEnumerable<Media> GetMediaByTitle(string searchString)
        {
            return _movieRepository.ReadMediaByTitle(searchString);
        }
    }
}