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

        private readonly Part[] parts;
        private readonly Random random = new Random();
        private readonly static string[] numbers = new[] { "3", "12", "100", "500", "A Thousand" };
        private readonly static string[] frequencies = new[] { "Always", "Forever", "Never", "Seldom", "Sometimes" };

        private readonly static string[] possessives = new[]
        {
            "My",
            "His",
            "Her",
            "Our",
            "Their",
            "Your"
        };

        private readonly static string[] prepositions = new[]
        {
            "Above",
            "Across",
            "After",
            "Against",
            "Around",
            "Before",
            "Beyond",
            "By",
            "Despite",
            "During",
            "For",
            "From",
            "Near",
            "Of",
            "Over",
            "Through",
            "To",
            "Toward",
            "Under",
            "Until",
            "With",
        };

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
                    Part.Adjective => PickWord(genre.Adjectives),
                    Part.Dont => "Don't",
                    Part.Frequency => PickWord(frequencies),
                    Part.MeA => "me a",
                    Part.Number => PickWord(numbers),
                    Part.PluralNoun => PickWord(genre.PluralNouns),
                    Part.Possessive => PickWord(possessives),
                    Part.Preposition => PickWord(prepositions),
                    Part.SingularNoun => PickWord(genre.SingularNouns),
                    Part.SingularNounPossessive => PickWord(genre.SingularNouns) + "'s",
                    Part.The => "The",
                    Part.ThirdPersonPluralVerb => PickWord(genre.ThirdPersonPluralVerbs),
                    Part.ThirdPersonSingularVerb => PickWord(genre.ThirdPersonSingularVerbs),
                    Part.TransitiveVerb => PickWord(genre.TransitiveVerbs),
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
