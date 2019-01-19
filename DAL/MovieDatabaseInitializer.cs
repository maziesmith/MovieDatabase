using System;
using System.Collections.Generic;
using MovieDatabase.BL.Domain;

namespace MovieDatabase.DAL
{
    public class MovieDatabaseInitializer
    {
        private static bool _hasRun;

        public static void Initialize(MovieDatabaseDbContext context, bool dropDatabase = false)
        {
            if (!_hasRun)
            {
                if (dropDatabase)
                {
                    context.Database.EnsureDeleted();
                }

                if (context.Database.EnsureCreated())
                {
                    Seed(context);
                }

                _hasRun = true;
            }
        }

        static void Seed(MovieDatabaseDbContext ctx)
        {
            Movie m1 = new Movie
            {
                Id = 1,
                Title = "Iron man",
                ReleaseDate = 2008,
                WatchDate = new DateTime(2015, 1, 5),
                MediaGenres = new List<MediaGenre>()
            };
            Movie m2 = new Movie
            {
                Id = 2,
                Title = "The Wolf of Wallstreet",
                ReleaseDate = 2013,
                WatchDate = new DateTime(2017, 4, 14),
                MediaGenres = new List<MediaGenre>()
            };
            Movie m3 = new Movie
            {
                Id = 3,
                Title = "Captain America: Civil War",
                ReleaseDate = 2016,
                WatchDate = new DateTime(2017, 1, 9),
                MediaGenres = new List<MediaGenre>{new MediaGenre(), new MediaGenre()}
            };
            Movie m4 = new Movie
            {
                Id = 4,
                Title = "Terminator",
                ReleaseDate = 1984,
                WatchDate = new DateTime(2018, 5, 5),
                MediaGenres = new List<MediaGenre>{new MediaGenre(), new MediaGenre()}
            };
            Series s1 = new Series
            {
                Id = 5,
                Title = "Vikings",
                Season = 1,
                Channel = "History",
                MediaGenres = new List<MediaGenre>{new MediaGenre(), new MediaGenre()}
            };
            Series s3 = new Series
            {
                Id = 7,
                Title = "Game of Thrones",
                Season = 1,
                Channel = "HBO",
                MediaGenres = new List<MediaGenre>{new MediaGenre(), new MediaGenre()}
            };
            ActorAct aa1 = new ActorAct {Actor = new Actor {Name = "Robert Downey Jr"}, Media = m1};
            ActorAct aa2 = new ActorAct {Actor = new Actor {Name = "Terrence Howard"}, Media = m1};
            ActorAct aa3 = new ActorAct {Actor = new Actor {Name = "Scarlett Johanson"}, Media = m3};
            ActorAct aa4 = new ActorAct {Actor = new Actor {Name = "Travis Fimmel"}, Media = s1};

            MediaGenre mg1 = new MediaGenre {Genre = Genre.ScienceFiction, Id = 1, Media = m1};
            MediaGenre mg2 = new MediaGenre {Genre = Genre.Action, Id = 2, Media = m1};
            MediaGenre mg3 = new MediaGenre {Genre = Genre.Horror, Id = 3, Media = m2};
            m1.MediaGenres = new List<MediaGenre> {mg1, mg2};
            m2.MediaGenres = new List<MediaGenre> {mg3};
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
            ctx.Series.AddRange(s3);
            ctx.ActorActs.AddRange(aa1, aa2, aa3, aa4);
            ctx.SaveChanges();
        }
    }
}