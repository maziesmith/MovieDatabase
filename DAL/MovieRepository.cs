using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieDatabase.BL.Domain;

namespace MovieDatabase.DAL
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDatabaseDbContext _ctx = new MovieDatabaseDbContext();

        public void Create(Media media)
        {
            _ctx.Media.Attach(media);
            _ctx.SaveChanges();
        }

        public Media Read(int id)
        {
            return _ctx.Media
                .Include(m => m.MediaGenres)
                .Include(m => m.ActorActs)
                .ThenInclude(aa => aa.Actor)
                .FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Media> ReadAll()
        {
            return _ctx.Media.Include(m => m.ActorActs).ThenInclude(aa => aa.Actor);
        }

        public IEnumerable<Media> ReadByTitle(string title)
        {
            return _ctx.Media.Include(m => m.ActorActs).Where(m => m.Title.ToLower().Contains(title.ToLower()));
        }

        public void Update(Media media)
        {
            Media m = Read(media.Id);
            m.Title = media.Title;
            m.ReleaseDate = media.ReleaseDate;
            m.Rating = media.Rating;
            m.Priority = media.Priority;
            m.WatchDate = media.WatchDate;
            m.ActorActs = media.ActorActs;
            m.MediaGenres = media.MediaGenres;
            _ctx.SaveChanges();
        }

        public void Delete(Media media)
        {
            _ctx.Media.Remove(media);
            _ctx.SaveChanges();
        }
    }
}