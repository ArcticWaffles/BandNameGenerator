using System.Collections.Generic;

namespace BandNameGenerator.Genres
{
    public class Country : IGenre
    {
        public List<string> SingularNouns { get; } = new List<string>() { "Boot" };
        public List<string> PluralNouns { get; } = new List<string>() { "Boots" };
        public List<string> Adjectives { get; } = new List<string>() { "Dusty" };
        public List<string> ThirdPersonSingularVerbs { get; } = new List<string>() { "Sings" };
        public List<string> ThirdPersonPluralVerbs { get; } = new List<string>() { "Sing" };
        public List<string> TransitiveVerbs { get; } = new List<string>() { "Sing" };

        public List<Formula> Formulas { get; } = new List<Formula>() {
            SharedFormulas.ThePluralNoun,
            SharedFormulas.TransitiveVerbMeASingularNoun,
            SharedFormulas.TheAdjectiveSingularNoun,
            SharedFormulas.TheAdjectivePluralNoun,
            SharedFormulas.AdjectiveSingularNoun,
            SharedFormulas.AdjectivePluralNoun,
            SharedFormulas.SingularNounPossessiveSingularNoun,
            SharedFormulas.TheSingularNounFrequencyVerb,
            SharedFormulas.PluralNounDontVerb,
            SharedFormulas.AdjectivePluralNounDontVerb
        };
    }
}
