using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandNameGenerator
{
    public interface IGenre
    {
        List<string> SingularNouns { get; }
        List<string> PluralNouns { get; }
        List<string> Adjectives { get; }
        List<string> ThirdPersonSingularVerbs { get; }
        List<string> ThirdPersonPluralVerbs { get; }
        List<string> TransitiveVerbs { get; }
        List<Formula> Formulas { get; }
    }
}
