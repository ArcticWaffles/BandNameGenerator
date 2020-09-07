using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandNameGenerator.Genres
{
    public class Metal : IGenre
    {
        private readonly  List<string> singularNouns = new List<string>() { "da" };
        public  List<string> SingularNouns => singularNouns;

        private readonly  List<string> pluralNouns = new List<string>() { "da" };
        public  List<string> PluralNouns => pluralNouns;

        private readonly List<string> adjectives = new List<string>() { "da" };
        public  List<string> Adjectives => adjectives;

        private readonly List<string> verbs = new List<string>() { "da" };
        public List<string> Verbs => verbs;
    }
}
