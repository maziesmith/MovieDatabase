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
            Media m1 = new Media
            {
                Id = 1,
                Title = "Iron man",
                ReleaseDate = 2008,
                WatchDate = new DateTime(2015, 1, 5),
                MediaGenres = new List<MediaGenre>(),
                ActorActs = new List<ActorAct>()
            };
            Media m2 = new Media
            {
                Id = 2,
                Title = "The Wolf of Wallstreet",
                ReleaseDate = 2013,
                WatchDate = new DateTime(2017, 4, 14),
                MediaGenres = new List<MediaGenre>(),
                ActorActs = new List<ActorAct>()
            };
            Media m3 = new Media
            {
                Id = 3,
                Title = "Captain America: Civil War",
                ReleaseDate = 2016,
                WatchDate = new DateTime(2017, 1, 9),
                MediaGenres = new List<MediaGenre> {new MediaGenre(), new MediaGenre()},
                ActorActs = new List<ActorAct>()
            };
            Media m4 = new Media
            {
                Id = 4,
                Title = "Terminator",
                ReleaseDate = 1984,
                WatchDate = new DateTime(2018, 5, 5),
                MediaGenres = new List<MediaGenre> {new MediaGenre(), new MediaGenre()},
                ActorActs = new List<ActorAct>()
            };
            Media m5 = new Media
            {
                Id = 5,
                Title = "Vikings - season 1 - 4",
                MediaGenres = new List<MediaGenre> {new MediaGenre(), new MediaGenre()},
                ActorActs = new List<ActorAct>()
            };
            Media m6 = new Media
            {
                Id = 7,
                Title = "Game of Thrones - season 1-7",
                MediaGenres = new List<MediaGenre> {new MediaGenre(), new MediaGenre()},
                ActorActs = new List<ActorAct>()
            };
            ActorAct aa1 = new ActorAct {Actor = new Actor {Name = "Robert Downey Jr"}, Media = m1};
            ActorAct aa2 = new ActorAct {Actor = new Actor {Name = "Terrence Howard"}, Media = m1};
            ActorAct aa3 = new ActorAct {Actor = new Actor {Name = "Scarlett Johanson"}, Media = m3};
            ActorAct aa4 = new ActorAct {Actor = new Actor {Name = "Travis Fimmel"}, Media = m5};

            /*
            m1.ActorActs.Add(aa1);
            m1.ActorActs.Add(aa2);
            m3.ActorActs.Add(aa3);
            m5.ActorActs.Add(aa4);
            */

            MediaGenre mg1 = new MediaGenre {Genre = Genre.ScienceFiction, Id = 1, Media = m1};
            MediaGenre mg2 = new MediaGenre {Genre = Genre.Action, Id = 2, Media = m1};
            MediaGenre mg3 = new MediaGenre {Genre = Genre.Horror, Id = 3, Media = m2};
            m1.MediaGenres = new List<MediaGenre> {mg1, mg2};
            m2.MediaGenres = new List<MediaGenre> {mg3};

            ctx.Media.AddRange(m1, m2, m3, m4, m5, m6);
            ctx.ActorActs.AddRange(aa1, aa2, aa3, aa4);
            ctx.SaveChanges();
        }
    }
}