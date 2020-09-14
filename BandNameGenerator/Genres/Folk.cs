using System.Collections.Generic;

namespace BandNameGenerator.Genres
{
    public class Folk : IGenre
    {
        public List<string> SingularNouns { get; } = new List<string>() { "Critter" };
        public List<string> PluralNouns { get; } = new List<string>() { "Critters" };
        public List<string> Adjectives { get; } = new List<string>() { "Sorrowful" };
        public List<string> ThirdPersonSingularVerbs { get; } = new List<string>() { "Cries" };
        public List<string> ThirdPersonPluralVerbs { get; } = new List<string>() { "Cry" };
        public List<string> TransitiveVerbs { get; } = new List<string>() { "Cry" };

        public List<Formula> Formulas { get; } = new List<Formula>() {
            SharedFormulas.NumberPluralNoun,
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
