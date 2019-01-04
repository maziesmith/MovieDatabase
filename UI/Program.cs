using System;
using MovieDatabase.BL;
using MovieDatabase.BL.Domain;
using MovieDatabase.DAL;

namespace MovieDatabase.UI.CA
{
    class Program
    {
        private static readonly MovieManager _movieManager = new MovieManager(); //TODO: static? --> later in mvc?

        static void Main(string[] args)
        {
            TestData();
        }

        private static void TestData()
        {
            Genre g = new Genre
            {
                Name = "Actie"
            };
            Genre g2 = new Genre
            {
                Name = "actie"
            };
            Movie m = new Movie
            {
                Title = "Iron man",
                ReleaseDate = 2008,
                Genre = g
            };
            Movie m2 = new Movie
            {
                Title = "Iron man 2",
                ReleaseDate = 2010,
                Genre = g
            };
            Series s = new Series
            {
                Title = "Vikings",
                Season = 1,
                ReleaseDate = 2013,
                Genre = g2
            };
            _movieManager.AddMovie(m);
            _movieManager.AddMovie(m2);
            _movieManager.AddSeries(s);
            foreach (Media media in _movieManager.GetAllMedia())
            {
                Console.WriteLine(media.ToString());
                Console.WriteLine(media.Genre.Name);
                Console.WriteLine();
            }
        }
    }
}