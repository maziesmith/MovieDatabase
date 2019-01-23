using System.Collections;
using System.Collections.Generic;
using MovieDatabase.BL.Domain;

namespace MovieDatabase.DAL
{
    public interface IMovieRepository
    {
        void Create(Media media);
        Media Read(int id);
        IEnumerable<Media> ReadAll();
        IEnumerable<Media> ReadByTitle(string title);
        void Update(Media media);
        void Delete(Media media);
    }
}