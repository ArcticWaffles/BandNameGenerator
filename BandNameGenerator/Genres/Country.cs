using System.Collections.Generic;

namespace BandNameGenerator.Genres
{
    public class Country : Genre
    {
        public Country()
        {
            SingularNouns = new[] { "Boot" };
            PluralNouns = new[] { "Boots" };
            Adjectives = new[] { "Dusty" };
            ThirdPersonSingularVerbs = new[] { "Sings" };
            ThirdPersonPluralVerbs = new[] { "Sing" };
            TransitiveVerbs = new[] { "Sing" };
            GenreSpecificFormulas = new List<Formula>
            {
                SharedFormulas.NumberPluralNoun,
                SharedFormulas.TransitiveVerbMeASingularNoun,
                SharedFormulas.PluralNounDontVerb,
                SharedFormulas.AdjectivePluralNounDontVerb,
                SharedFormulas.NumberAdjectivePluralNoun
            };
        }
    }
}
