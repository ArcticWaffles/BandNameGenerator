using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandNameGenerator.Genres
{
    public abstract class Genre
    {
        public Genre()
        {
            Formulas = new List<Formula>
            {
                SharedFormulas.ThePluralNoun,
                SharedFormulas.TheAdjectiveSingularNoun,
                SharedFormulas.TheAdjectivePluralNoun,
                SharedFormulas.AdjectiveSingularNoun,
                SharedFormulas.AdjectivePluralNoun,
                SharedFormulas.SingularNounPossessiveSingularNoun
            };

            Formulas.AddRange(GenreSpecificFormulas);
        }

        public abstract List<string> SingularNouns { get; }
        public abstract List<string> PluralNouns { get; }
        public abstract List<string> Adjectives { get; }
        public abstract List<string> ThirdPersonSingularVerbs { get; }
        public abstract List<string> ThirdPersonPluralVerbs { get; }
        public abstract List<string> TransitiveVerbs { get; }

        protected virtual List<Formula> Formulas { get; }

        protected virtual List<Formula> GenreSpecificFormulas { get; } = new List<Formula>();

        public Formula PickFormula()
        {
            var randomIndex = new Random().Next(Formulas.Count);
            return Formulas[randomIndex];
        }
    }
}
