using System.Collections.Generic;
using MovieDatabase.BL.Domain;
using MovieDatabase.DAL;

namespace MovieDatabase.BL
{
    public interface IMovieManager
    {
        void Add(Media media);
        Media Get(int id);
        IEnumerable<Media> GetAll();
        IEnumerable<Media> GetByTitle(string title);
        void Change(Media media);
        void Remove(Media media);
    }
}