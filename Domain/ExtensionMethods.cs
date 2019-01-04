namespace MovieDatabase.BL.Domain
{
    public static class ExtensionMethods
    {
        public static string MediaTypeToString(this MediaType mediaType)
        {
            switch (mediaType)
            {
                case MediaType.Movie: return "Movie";
                case MediaType.Series: return "Series";
                default: return "";
            }
        }
    }
}