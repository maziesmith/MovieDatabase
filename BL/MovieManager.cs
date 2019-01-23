using System.Collections.Generic;
using MovieDatabase.BL.Domain;
using MovieDatabase.DAL;

namespace MovieDatabase.BL
{
    public class MovieManager : IMovieManager
    {
        private readonly IMovieRepository _repo;

        public MovieManager()
        {
            _repo = new MovieRepository();
        }

        public void Add(Media media)
        {
            _repo.Create(media);
        }

        public Media Get(int id)
        {
            return _repo.Read(id);
        }

        public IEnumerable<Media> GetAll()
        {
            return _repo.ReadAll();
        }

        public IEnumerable<Media> GetByTitle(string title)
        {
            return _repo.ReadByTitle(title);
        }


        public void Change(Media media)
        {
            _repo.Update(media);
        }


        public void Remove(Media media)
        {
            _repo.Delete(media);
        }
    }
}