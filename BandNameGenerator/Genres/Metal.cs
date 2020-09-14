using System;
using System.Collections.Generic;

namespace BandNameGenerator.Genres
{
    public class Metal : IGenre
    {
        public List<string> SingularNouns { get; } = new List<string>() { "Nail" };
        public List<string> PluralNouns { get; } = new List<string>() { "Nails" };
        public List<string> Adjectives { get; } = new List<string>() { "Bloody" };
        public List<string> ThirdPersonSingularVerbs { get; } = new List<string>() { "Screeches" };
        public List<string> ThirdPersonPluralVerbs { get; } = new List<string>() { "Screech" };
        public List<string> TransitiveVerbs { get; } = new List<string>();

        public List<Formula> Formulas { get; } = new List<Formula>() {
            SharedFormulas.ThePluralNoun,
            SharedFormulas.TheAdjectiveSingularNoun,
            SharedFormulas.TheAdjectivePluralNoun,
            SharedFormulas.AdjectiveSingularNoun,
            SharedFormulas.AdjectivePluralNoun,
            SharedFormulas.SingularNounPossessiveSingularNoun
        };
    }
}
