using System.Collections.Generic;

namespace BandNameGenerator.Genres
{
    public class Folk : IGenre
    {
        private readonly List<string> singularNouns = new List<string>() { "Critter" };
        public List<string> SingularNouns => singularNouns;

        private readonly static List<string> pluralNouns = new List<string>() { "Critters" };
        public List<string> PluralNouns => pluralNouns;

        private readonly List<string> adjectives = new List<string>() { "Sorrowful" };
        public List<string> Adjectives => adjectives;

        private readonly List<string> thirdPersonSingularVerbs = new List<string>() { "Cries" };
        public List<string> ThirdPersonSingularVerbs => thirdPersonSingularVerbs;

        private readonly List<string> thirdPersonPluralVerbs = new List<string>() { "Cry" };
        public List<string> ThirdPersonPluralVerbs => thirdPersonPluralVerbs;

        private readonly List<string> transitiveVerbs = new List<string>() { "Cry" };
        public List<string> TransitiveVerbs => transitiveVerbs;

        private readonly List<Formula> formulas = new List<Formula>() {
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
        public List<Formula> Formulas => formulas;
    }
}
