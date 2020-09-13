using System;
using System.Collections.Generic;

namespace BandNameGenerator.Genres
{
    public class Metal : IGenre
    {
        private readonly List<string> singularNouns = new List<string>() { "Nail" };
        public List<string> SingularNouns => singularNouns;

        private readonly List<string> pluralNouns = new List<string>() { "Nails" };
        public List<string> PluralNouns => pluralNouns;

        private readonly List<string> adjectives = new List<string>() { "Bloody" };
        public List<string> Adjectives => adjectives;

        private readonly List<string> thirdPersonSingularVerbs = new List<string>() { "Screeches" };
        public List<string> ThirdPersonSingularVerbs => thirdPersonSingularVerbs;

        private readonly List<string> thirdPersonPluralVerbs = new List<string>() { "Screech" };
        public List<string> ThirdPersonPluralVerbs => thirdPersonPluralVerbs;

        public List<string> TransitiveVerbs => throw new NotImplementedException();

        private readonly List<Formula> formulas = new List<Formula>() {
            SharedFormulas.ThePluralNoun,
            SharedFormulas.TheAdjectiveSingularNoun,
            SharedFormulas.TheAdjectivePluralNoun,
            SharedFormulas.AdjectiveSingularNoun,
            SharedFormulas.AdjectivePluralNoun,
            SharedFormulas.SingularNounPossessiveSingularNoun
        };
        public List<Formula> Formulas => formulas;
    }
}
