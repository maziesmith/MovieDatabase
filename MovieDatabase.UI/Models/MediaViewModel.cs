using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MovieDatabase.BL.Domain;

namespace MovieDatabase.UI.Models
{
    public class MediaViewModel : IValidatableObject
    {
        public Media Media { get; set; }
        public List<string> Actors { get; set; }
        public List<Genre> Genres { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (Actors != null && Actors.Any())
            {
                bool duplicates = Actors.GroupBy(a => a).Any(a => a.Count() > 1);
                if (duplicates)
                {
                    errors.Add(new ValidationResult("Duplicate actors", new[] {"Actors"}));
                }
            }

            return errors;
        }
    }
}