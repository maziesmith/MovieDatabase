using System;
using System.Linq;
using MovieDatabase.BL.Domain;

namespace MovieDatabase.DAL
{
    public class ActorRepository : IActorRepository
    {
        private readonly MovieDatabaseDbContext _ctx = new MovieDatabaseDbContext();

        public bool Exists(string name)
        {
            return _ctx.Actors.Count(a => string.Equals(a.Name, name, StringComparison.InvariantCultureIgnoreCase)) > 0;
        }

        public Actor ReadByName(string name)
        {
            return _ctx.Actors.FirstOrDefault(a =>
                string.Equals(a.Name, name, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}