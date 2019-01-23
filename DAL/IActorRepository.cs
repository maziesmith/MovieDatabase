using MovieDatabase.BL.Domain;

namespace MovieDatabase.DAL
{
    public interface IActorRepository
    {
        bool Exists(string name);
        Actor ReadByName(string name);
    }
}