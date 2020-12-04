using BandNameGenerator;
using BandNameGenerator.Genres;
using System;
using System.Collections.Generic;
using System.Text;

namespace BandNameGeneratorTests
{
    public class TestGenre : Genre
    {
        public TestGenre(Formula formula)
        {
            SingularNouns = new[] { "Cat" };
            PluralNouns = new[] { "Cats" };
            Adjectives = new[] { "Fuzzy" };
            ThirdPersonPluralVerbs = new[] { "Meow" };
            ThirdPersonSingularVerbs = new[] { "Meows" };
            TransitiveVerbs = new[] { "Scratch" };

            formulas.Clear();
            formulas.Add(formula);
        }
    }
}
