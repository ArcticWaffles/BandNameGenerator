using System.Collections.Generic;

namespace BandNameGenerator.Genres
{
    public class Country : IGenre
    {
        private readonly List<string> singularNouns = new List<string>() { "Boot" };
        public List<string> SingularNouns => singularNouns;

        private readonly static List<string> pluralNouns = new List<string>() { "Boots" };
        public List<string> PluralNouns => pluralNouns;

        private readonly List<string> adjectives = new List<string>() { "Dusty" };
        public List<string> Adjectives => adjectives;

        private readonly List<string> thirdPersonSingularVerbs = new List<string>() { "Sings" };
        public List<string> ThirdPersonSingularVerbs => thirdPersonSingularVerbs;

        private readonly List<string> thirdPersonPluralVerbs = new List<string>() { "Sing" };
        public List<string> ThirdPersonPluralVerbs => thirdPersonPluralVerbs;

        private readonly List<string> transitiveVerbs = new List<string>() { "Sing" };
        public List<string> TransitiveVerbs => transitiveVerbs;

        private readonly List<Formula> formulas = new List<Formula>() {
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
        public List<Formula> Formulas => formulas;
    }
}
