using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BandNameGenerator.Formula;

namespace BandNameGenerator.Genres
{
    public abstract class Genre
    {
        protected readonly List<Formula> formulas;

        readonly Random random = new Random();
        readonly static string[] numbers = new[] { "3", "12", "100", "500", "A Thousand" };
        readonly static string[] frequencies = new[] { "Always", "Forever", "Never", "Seldom", "Sometimes" };

        readonly static string[] possessives = new[]
        {
            "My",
            "His",
            "Her",
            "Our",
            "Their",
            "Your"
        };

        readonly static string[] prepositions = new[]
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

        public Genre()
        {
            formulas = new List<Formula>
            {
                SharedFormulas.ThePluralNoun,
                SharedFormulas.TheAdjectiveSingularNoun,
                SharedFormulas.TheAdjectivePluralNoun,
                SharedFormulas.AdjectiveSingularNoun,
                SharedFormulas.AdjectivePluralNoun,
                SharedFormulas.SingularNounPossessiveSingularNoun,
                SharedFormulas.PrepositionTheSingularNoun,
                SharedFormulas.PrepositionThePluralNoun,
                SharedFormulas.PrepositionTheAdjectiveSingularNoun,
                SharedFormulas.PluralNounPrepositionTheSingularNoun,
                SharedFormulas.AdjectiveAdjectiveSingularNoun,
                SharedFormulas.PossessiveAdjectiveSingularNoun
            };
        }

        public string[] SingularNouns { get; protected set; } = new string[] { };
        public string[] PluralNouns { get; protected set; } = new string[] { };
        public string[] Adjectives { get; protected set; } = new string[] { };
        public string[] ThirdPersonSingularVerbs { get; protected set; } = new string[] { };
        public string[] ThirdPersonPluralVerbs { get; protected set; } = new string[] { };
        public string[] TransitiveVerbs { get; protected set; } = new string[] { };

        public Formula PickFormula()
        {
            var randomIndex = random.Next(formulas.Count);
            return formulas[randomIndex];
        }

        public string GenerateName()
        {
            var formula = PickFormula();
            var strings =
                from part in formula
                select part switch
                {
                    Part.Adjective => PickWord(Adjectives),
                    Part.Dont => "Don't",
                    Part.Frequency => PickWord(frequencies),
                    Part.MeA => "me a",
                    Part.Number => PickWord(numbers),
                    Part.PluralNoun => PickWord(PluralNouns),
                    Part.Possessive => PickWord(possessives),
                    Part.Preposition => PickWord(prepositions),
                    Part.SingularNoun => PickWord(SingularNouns),
                    Part.SingularNounPossessive => PickWord(SingularNouns) + "'s",
                    Part.The => "The",
                    Part.ThirdPersonPluralVerb => PickWord(ThirdPersonPluralVerbs),
                    Part.ThirdPersonSingularVerb => PickWord(ThirdPersonSingularVerbs),
                    Part.TransitiveVerb => PickWord(TransitiveVerbs),
                    _ => "",
                };
            return string.Join(' ', strings);
        }

        string PickWord(IEnumerable<string> words)
        {
            if (!words.Any()) return "";
            var randomIndex = random.Next(words.Count());
            return words.ElementAt(randomIndex);
        }
    }
}
