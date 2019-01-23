using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MovieDatabase.BL.Domain
{
    using System;
    using System.Collections.Generic;

    public class Media : IValidatableObject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? ReleaseDate { get; set; } // Year
        public int? Priority { get; set; }
        [Range(1, 5)] public int? Rating { get; set; }
        public MediaType MediaType { get; set; }
        public DateTime? WatchDate { get; set; }

        public ICollection<ActorAct> ActorActs { get; set; }
        public IList<MediaGenre> MediaGenres { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (ReleaseDate != null && WatchDate != null)
            {
                if (WatchDate.Value.Year < ReleaseDate)
                {
                    errors.Add(new ValidationResult("Watch date cannot be before release date!",
                        new[] {"ReleaseDate", "WatchDate"}));
                }
            }


            if (Rating != null)
            {
                if (Rating < 1 || Rating > 5)
                {
                    errors.Add(new ValidationResult("Rating has to be between 1 and 5", new[] {"Rating"}));
                }
            }

            return errors;
        }
    }
}