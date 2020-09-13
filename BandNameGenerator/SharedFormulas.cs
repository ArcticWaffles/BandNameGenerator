using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandNameGenerator
{
    public static class SharedFormulas
    {
        private static readonly Formula numberPluralNoun = new Formula(new List<Formula.Part>(){
            Formula.Part.Number,
            Formula.Part.PluralNoun });
        public static Formula NumberPluralNoun => numberPluralNoun;


        private static readonly Formula thePluralNoun = new Formula(new List<Formula.Part>(){
            Formula.Part.The,
            Formula.Part.PluralNoun });
        public static Formula ThePluralNoun => thePluralNoun;


        private static readonly Formula transitiveVerbMeASingularNoun = new Formula(new List<Formula.Part>(){
            Formula.Part.TransitiveVerb,
            Formula.Part.MeA,
            Formula.Part.SingularNoun });
        public static Formula TransitiveVerbMeASingularNoun => transitiveVerbMeASingularNoun;


        private static readonly Formula theAdjectiveSingularNoun = new Formula(new List<Formula.Part>(){
            Formula.Part.The,
            Formula.Part.Adjective,
            Formula.Part.SingularNoun });
        public static Formula TheAdjectiveSingularNoun => theAdjectiveSingularNoun;


        private static readonly Formula theAdjectivePluralNoun = new Formula(new List<Formula.Part>(){
            Formula.Part.The,
            Formula.Part.Adjective,
            Formula.Part.PluralNoun });
        public static Formula TheAdjectivePluralNoun => theAdjectivePluralNoun;


        private static readonly Formula adjectiveSingularNoun = new Formula(new List<Formula.Part>(){
            Formula.Part.Adjective,
            Formula.Part.SingularNoun });
        public static Formula AdjectiveSingularNoun => adjectiveSingularNoun;


        private static readonly Formula adjectivePluralNoun = new Formula(new List<Formula.Part>(){
            Formula.Part.Adjective,
            Formula.Part.PluralNoun });
        public static Formula AdjectivePluralNoun => adjectivePluralNoun;


        private static readonly Formula singularNounPossessiveSingularNoun = new Formula(new List<Formula.Part>(){
            Formula.Part.SingularNounPossessive,
            Formula.Part.SingularNoun });
        public static Formula SingularNounPossessiveSingularNoun => singularNounPossessiveSingularNoun;


        private static readonly Formula theSingularNounFrequencyVerb = new Formula(new List<Formula.Part>(){
            Formula.Part.The,
            Formula.Part.SingularNoun,
            Formula.Part.Frequency,
            Formula.Part.ThirdPersonSingularVerb});
        public static Formula TheSingularNounFrequencyVerb => theSingularNounFrequencyVerb;


        private static readonly Formula pluralNounDontVerb = new Formula(new List<Formula.Part>(){
            Formula.Part.PluralNoun,
            Formula.Part.Dont,
            Formula.Part.ThirdPersonPluralVerb });
        public static Formula PluralNounDontVerb => pluralNounDontVerb;


        private static readonly Formula adjectivePluralNounDontVerb = new Formula(new List<Formula.Part>(){
            Formula.Part.Adjective,
            Formula.Part.PluralNoun,
            Formula.Part.Dont,
            Formula.Part.ThirdPersonPluralVerb });
        public static Formula AdjectivePluralNounDontVerb => adjectivePluralNounDontVerb;
    }
}
