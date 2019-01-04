using System.Collections.Generic;

namespace MovieDatabase.BL.Domain
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public ICollection<Media> Media { get; set; }
        public ICollection<ActorAct> ActorActs { get; set; }
    }
}