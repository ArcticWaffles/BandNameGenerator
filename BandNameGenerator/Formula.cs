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
            Verb,
            InitialThe,
            OfThe
        }

        private readonly List<Part> parts;

        private readonly static List<string> numbers = new List<string>() { "3", "12", "100", "500", "A Thousand" };

        public Formula(List<Part> parts)
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
                    Part.Verb => PickWord(genre.Verbs),
                    Part.InitialThe => "The",
                    Part.OfThe => "of the",
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
