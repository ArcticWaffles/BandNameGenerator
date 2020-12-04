using BandNameGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static BandNameGenerator.Formula;

namespace BandNameGeneratorTests
{
    [TestClass]
    public class GenreTests
    {
        [TestMethod]
        [DataRow(Part.SingularNoun, "Cat")]
        [DataRow(Part.PluralNoun, "Cats")]
        [DataRow(Part.Dont, "Don't")]
        [DataRow(Part.MeA, "me a")]
        [DataRow(Part.SingularNounPossessive, "Cat's")]
        [DataRow(Part.Adjective, "Fuzzy")]
        [DataRow(Part.The, "The")]
        [DataRow(Part.ThirdPersonPluralVerb, "Meow")]
        [DataRow(Part.ThirdPersonSingularVerb, "Meows")]
        [DataRow(Part.TransitiveVerb, "Scratch")]
        public void GenerateName_ShouldReturnCorrectName(Formula.Part part, string expected)
        {
            var formula = new Formula { part };
            var genre = new TestGenre(formula);
            var result = genre.GenerateName();
            Assert.AreEqual(expected, result);
        }
    }
}
