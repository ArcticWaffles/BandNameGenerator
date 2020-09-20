using System;
using System.Collections.Generic;

namespace BandNameGenerator.Genres
{
    public class Metal : Genre
    {
        public override List<string> SingularNouns { get; } = new List<string>() { "Nail" };
        public override List<string> PluralNouns { get; } = new List<string>() { "Nails" };
        public override List<string> Adjectives { get; } = new List<string>() { "Bloody" };
        public override List<string> ThirdPersonSingularVerbs { get; } = new List<string>() { "Screeches" };
        public override List<string> ThirdPersonPluralVerbs { get; } = new List<string>() { "Screech" };
        public override List<string> TransitiveVerbs { get; } = new List<string>();

    }
}
