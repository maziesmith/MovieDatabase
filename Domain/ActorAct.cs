namespace MovieDatabase.BL.Domain
{
    public class ActorAct
    {
        public Media Media { get; set; }
        public Actor Actor { get; set; }
        public int ActorId { get; set; }
        public int MediaId { get; set; }
    }
}