﻿using System.Collections.Generic;

namespace BandNameGenerator.Genres
{
    public class Folk : Genre
    {
        public Folk()
        {
            SingularNouns = new[] { "Critter" };
            PluralNouns = new[] { "Critters" };
            Adjectives = new[] { "Sorrowful" };
            ThirdPersonSingularVerbs = new[] { "Cries" };
            ThirdPersonPluralVerbs = new[] { "Cry" };
            TransitiveVerbs = new[] { "Cry" };

            AddFormulas(new[]
            {
                SharedFormulas.NumberPluralNoun,
                SharedFormulas.TransitiveVerbMeASingularNoun,
                SharedFormulas.TheSingularNounFrequencyVerb,
                SharedFormulas.NumberAdjectivePluralNoun
            });
        }
    }
}
