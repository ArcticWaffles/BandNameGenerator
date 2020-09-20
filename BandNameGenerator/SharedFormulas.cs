namespace BandNameGenerator
{
    public static class SharedFormulas
    {
        public static Formula NumberPluralNoun { get; } = new Formula(
            Formula.Part.Number,
            Formula.Part.PluralNoun);

        public static Formula ThePluralNoun { get; } = new Formula(
            Formula.Part.The,
            Formula.Part.PluralNoun);

        public static Formula TransitiveVerbMeASingularNoun { get; } = new Formula(
            Formula.Part.TransitiveVerb,
            Formula.Part.MeA,
            Formula.Part.SingularNoun);

        public static Formula TheAdjectiveSingularNoun { get; } = new Formula(
            Formula.Part.The,
            Formula.Part.Adjective,
            Formula.Part.SingularNoun);

        public static Formula TheAdjectivePluralNoun { get; } = new Formula(
            Formula.Part.The,
            Formula.Part.Adjective,
            Formula.Part.PluralNoun);

        public static Formula AdjectiveSingularNoun { get; } = new Formula(
            Formula.Part.Adjective,
            Formula.Part.SingularNoun);

        public static Formula AdjectivePluralNoun { get; } = new Formula(
            Formula.Part.Adjective,
            Formula.Part.PluralNoun);

        public static Formula SingularNounPossessiveSingularNoun { get; } = new Formula(
            Formula.Part.SingularNounPossessive,
            Formula.Part.SingularNoun);

        public static Formula TheSingularNounFrequencyVerb { get; } = new Formula(
            Formula.Part.The,
            Formula.Part.SingularNoun,
            Formula.Part.Frequency,
            Formula.Part.ThirdPersonSingularVerb);

        public static Formula PluralNounDontVerb { get; } = new Formula(
            Formula.Part.PluralNoun,
            Formula.Part.Dont,
            Formula.Part.ThirdPersonPluralVerb);

        public static Formula AdjectivePluralNounDontVerb { get; } = new Formula(
            Formula.Part.Adjective,
            Formula.Part.PluralNoun,
            Formula.Part.Dont,
            Formula.Part.ThirdPersonPluralVerb);

        public static Formula NumberAdjectivePluralNoun { get; } = new Formula(
            Formula.Part.Number,
            Formula.Part.Adjective,
            Formula.Part.PluralNoun);
    }
}
