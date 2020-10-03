using System;
using System.Collections.Generic;

namespace BandNameGenerator.Genres
{
    public class Metal : Genre
    {
        public Metal()
        {
            SingularNouns = new[] { "Nail" };
            PluralNouns = new[] { "Nails" };
            Adjectives = new[] { "Bloody" };
            ThirdPersonSingularVerbs = new[] { "Screeches" };
            ThirdPersonPluralVerbs = new[] { "Screech" };
        }
    }
}
