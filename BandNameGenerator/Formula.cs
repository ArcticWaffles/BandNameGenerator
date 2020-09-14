using System;
using System.Collections.Generic;
using System.Linq;

namespace BandNameGenerator
{
    public class Formula
    {
        public enum Part
        {
            SingularNoun,
            PluralNoun,
            Adjective,
            SingularNounPossessive,
            Number,
            ThirdPersonSingularVerb,
            ThirdPersonPluralVerb,
            TransitiveVerb,
            Frequency,
            The,
            OfThe,
            MeA,
            Dont
        }

        private readonly Part[] parts;

        private readonly static List<string> numbers = new List<string>() { "3", "12", "100", "500", "A Thousand" };

        private readonly static List<string> frequencies = new List<string>() { "Always", "Never", "Seldom" };

        public Formula(params Part[] parts)
        {
            this.parts = parts;
        }

        public string GetValue(IGenre genre)
        {
            var strings =
                from part in parts
                select part switch
                {
                    Part.SingularNoun => PickWord(genre.SingularNouns),
                    Part.PluralNoun => PickWord(genre.PluralNouns),
                    Part.Adjective => PickWord(genre.Adjectives),
                    Part.SingularNounPossessive => PickWord(genre.SingularNouns) + "'s",
                    Part.Number => PickWord(numbers),
                    Part.ThirdPersonSingularVerb => PickWord(genre.ThirdPersonSingularVerbs),
                    Part.ThirdPersonPluralVerb => PickWord(genre.ThirdPersonPluralVerbs),
                    Part.TransitiveVerb => PickWord(genre.TransitiveVerbs),
                    Part.Frequency => PickWord(frequencies),
                    Part.The => "The",
                    Part.OfThe => "of the",
                    Part.MeA => "me a",
                    Part.Dont => "Don't",
                    _ => "",
                };
            return string.Join(' ', strings);
        }
        //TODO: Unit tests?

        private string PickWord(List<string> words)
        {
            throw new NotImplementedException();
        }
    }
}
