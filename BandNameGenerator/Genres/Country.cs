using System.Collections.Generic;

namespace BandNameGenerator.Genres
{
    public class Country : Genre
    {
        public override List<string> SingularNouns { get; } = new List<string>() { "Boot" };
        public override List<string> PluralNouns { get; } = new List<string>() { "Boots" };
        public override List<string> Adjectives { get; } = new List<string>() { "Dusty" };
        public override List<string> ThirdPersonSingularVerbs { get; } = new List<string>() { "Sings" };
        public override List<string> ThirdPersonPluralVerbs { get; } = new List<string>() { "Sing" };
        public override List<string> TransitiveVerbs { get; } = new List<string>() { "Sing" };

        protected override List<Formula> GenreSpecificFormulas { get; } = new List<Formula>
        {
            SharedFormulas.NumberPluralNoun,
            SharedFormulas.TransitiveVerbMeASingularNoun,
            SharedFormulas.PluralNounDontVerb,
            SharedFormulas.AdjectivePluralNounDontVerb,
            SharedFormulas.NumberAdjectivePluralNoun
        };
    }
}
