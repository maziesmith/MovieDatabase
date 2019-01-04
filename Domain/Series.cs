namespace MovieDatabase.BL.Domain
{
    public class Series : Media
    {
        public int Season { get; set; }
        public string Channel { get; set; }
    }
}