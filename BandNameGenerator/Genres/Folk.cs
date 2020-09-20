using System.Collections.Generic;

namespace BandNameGenerator.Genres
{
    public class Folk : Genre
    {
        public override List<string> SingularNouns { get; } = new List<string>() { "Critter" };
        public override List<string> PluralNouns { get; } = new List<string>() { "Critters" };
        public override List<string> Adjectives { get; } = new List<string>() { "Sorrowful" };
        public override List<string> ThirdPersonSingularVerbs { get; } = new List<string>() { "Cries" };
        public override List<string> ThirdPersonPluralVerbs { get; } = new List<string>() { "Cry" };
        public override List<string> TransitiveVerbs { get; } = new List<string>() { "Cry" };

        protected override List<Formula> GenreSpecificFormulas { get; } = new List<Formula>
        {
            SharedFormulas.NumberPluralNoun,
            SharedFormulas.TransitiveVerbMeASingularNoun,
            SharedFormulas.TheSingularNounFrequencyVerb,
            SharedFormulas.NumberAdjectivePluralNoun
        };
    }
}
