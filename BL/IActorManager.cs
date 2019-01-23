using MovieDatabase.BL.Domain;

namespace MovieDatabase.BL
{
    public interface IActorManager
    {
        bool Exists(string name);
        Actor GetByName(string name);
    }
}