using MovieDatabase.BL.Domain;
using MovieDatabase.DAL;

namespace MovieDatabase.BL
{
    public class ActorManager : IActorManager
    {
        private readonly IActorRepository _repo = new ActorRepository();


        public bool Exists(string name)
        {
            return _repo.Exists(name);
        }

        public Actor GetByName(string name)
        {
            if (Exists(name))
            {
                return _repo.ReadByName(name);
            }

            return null;
        }
    }
}