using System;
using System.Collections.Generic;
using System.Linq;

namespace BandNameGenerator
{
    public class Formula : List<Formula.Part>
    {
        public enum Part
        {
            Adjective,
            Dont,
            Frequency,
            MeA,
            Number,
            PluralNoun,
            Possessive,
            Preposition,
            SingularNoun,
            SingularNounPossessive,
            The,
            ThirdPersonPluralVerb,
            ThirdPersonSingularVerb,
            TransitiveVerb,
        }
    }
}
