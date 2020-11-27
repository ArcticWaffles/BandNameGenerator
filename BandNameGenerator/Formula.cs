using BandNameGenerator.Genres;
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
        private readonly Random random = new Random();
        private readonly static string[] numbers = new[] { "3", "12", "100", "500", "A Thousand" };
        private readonly static string[] frequencies = new[] { "Always", "Never", "Seldom" };

        public Formula(params Part[] parts)
        {
            this.parts = parts;
        }

        public string GetValue(Genre genre)
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

        private string PickWord(IEnumerable<string> words)
        {
            if (!words.Any()) return "";
            var randomIndex = random.Next(words.Count());
            return words.ElementAt(randomIndex);
        }
    }
}
