using System;
using System.Collections.Generic;
using MovieDatabase.BL.Domain;

namespace MovieDatabase.DAL
{
    public class MovieDatabaseInitializer
    {
        private static bool hasRun;

        public static void Initialize(MovieDatabaseDbContext context, bool dropDatabase = false)
        {
            if (!hasRun)
            {
                if (dropDatabase)
                {
                    context.Database.EnsureDeleted();
                }

                if (context.Database.EnsureCreated())
                {
                    Seed(context);
                }

                hasRun = true;
            }
        }

        static void Seed(MovieDatabaseDbContext ctx)
        {
            Genre action = new Genre {Name = "Action"};
            Genre scifi = new Genre {Name = "Sci-Fi"};
            Genre adventure = new Genre {Name = "Adventure"};
            Genre comedy = new Genre {Name = "Comedy"};
            Genre crime = new Genre {Name = "Crime"};
            Genre drama = new Genre {Name = "Drama"};
            Genre biography = new Genre {Name = "Biography"};

            Movie m1 = new Movie
            {
                Id = 1,
                Title = "Iron man",
                ReleaseDate = 2008,
                WatchDate = new DateTime(2015, 1, 5),
            };
            Movie m2 = new Movie
            {
                Id = 2,
                Title = "The Wolf of Wallstreet",
                ReleaseDate = 2013,
                WatchDate = new DateTime(2017, 4, 14),
            };
            Movie m3 = new Movie
            {
                Id = 3,
                Title = "Captain America: Civil War",
                ReleaseDate = 2016,
                WatchDate = new DateTime(2017, 1, 9),
            };
            Movie m4 = new Movie
            {
                Id = 4,
                Title = "Terminator",
                ReleaseDate = 1984,
                WatchDate = new DateTime(2018, 5, 5),
            };
            Series s1 = new Series
            {
                Id = 5,
                Title = "Vikings",
                Season = 1,
                Channel = "History"
            };
            Series s3 = new Series
            {
                Id = 7,
                Title = "Game of Thrones",
                Season = 1,
                Channel = "HBO"
            };
            ActorAct aa1 = new ActorAct {Actor = new Actor {Name = "Robert Downey Jr"}, Media = m1};
            ActorAct aa2 = new ActorAct {Actor = new Actor {Name = "Terrence Howard"}, Media = m1};
            ActorAct aa3 = new ActorAct {Actor = new Actor {Name = "Scarlett Johanson"}, Media = m3};
            ActorAct aa4 = new ActorAct {Actor = new Actor {Name = "Travis Fimmel"}, Media = s1};

            /*
            Test searching speed
            List<Movie> list = new List<Movie>();
            char[] charArr = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random random = new Random();
            for (int i = 0; i < 2000; i++)
            {
                string s = "";
                for (int j = 0; j < 6; j++)
                {
                    s += charArr[random.Next(0, 25)];
                }
                list.Add(new Movie {Title = s});
            }
            */

            ctx.Movies.AddRange(m2, m3, m4);
            ctx.ActorActs.AddRange(aa1, aa2, aa3, aa4);
            ctx.Series.AddRange(s3);
            ctx.SaveChanges();
        }
    }
}