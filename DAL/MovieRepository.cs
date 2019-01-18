using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieDatabase.BL.Domain;

namespace MovieDatabase.DAL
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDatabaseDbContext _context = new MovieDatabaseDbContext();

        public MovieDatabaseDbContext GetContext()
        {
            return _context;
        }


        public IEnumerable<Media> ReadAllMedia()
        {
            return _context.Media;
        }

        public Media ReadMedia(int id)
        {
            return _context.Media.Find(id);
        }

        public Movie ReadMovie(int id)
        {
            return _context.Movies.Find(id);
        }

        public Series ReadSeries(int id)
        {
            return _context.Series.Find(id);
        }

        public void CreateMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void CreateSeries(Series series)
        {
            _context.Series.Add(series);
            _context.SaveChanges();
        }

        //TODO: find a way to reduce duplicate code
        public void UpdateMovie(Movie movie)
        {
            Movie m = ReadMovie(movie.Id);
            m.Title = movie.Title;
            m.ReleaseDate = movie.ReleaseDate;
            m.Rating = movie.Rating;
            m.Priority = movie.Priority;
            m.IsPresent = movie.IsPresent;
            m.WatchDate = movie.WatchDate;
            m.ActorActs = movie.ActorActs;
            m.Duration = movie.Duration;
            _context.SaveChanges();
        }

        public void UpdateSeries(Series series)
        {
            Series s = ReadSeries(series.Id);
            s.Title = series.Title;
            s.ReleaseDate = series.ReleaseDate;
            s.Rating = series.Rating;
            s.Priority = series.Priority;
            s.IsPresent = series.IsPresent;
            s.WatchDate = series.WatchDate;
            s.ActorActs = series.ActorActs;
            s.Season = series.Season;
            s.Channel = series.Channel;
            _context.SaveChanges();
        }

        public void DeleteMedia(Media media)
        {
            _context.Media.Remove(media);
            _context.SaveChanges();
        }

        public IEnumerable<Media> ReadMediaByTitle(string searchString)
        {
            return _context.Media.Where(m => m.Title.ToLower().Contains(searchString.ToLower()));
        }
    }
}