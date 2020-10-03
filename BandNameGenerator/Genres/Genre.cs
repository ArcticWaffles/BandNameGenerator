﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandNameGenerator.Genres
{
    public abstract class Genre
    {
        private readonly List<Formula> formulas;

        public Genre()
        {
            formulas = new List<Formula>
            {
                SharedFormulas.ThePluralNoun,
                SharedFormulas.TheAdjectiveSingularNoun,
                SharedFormulas.TheAdjectivePluralNoun,
                SharedFormulas.AdjectiveSingularNoun,
                SharedFormulas.AdjectivePluralNoun,
                SharedFormulas.SingularNounPossessiveSingularNoun
            };
        }

        public string[] SingularNouns { get; protected set; } = new string[] { };
        public string[] PluralNouns { get; protected set; } = new string[] { };
        public string[] Adjectives { get; protected set; } = new string[] { };
        public string[] ThirdPersonSingularVerbs { get; protected set; } = new string[] { };
        public string[] ThirdPersonPluralVerbs { get; protected set; } = new string[] { };
        public string[] TransitiveVerbs { get; protected set; } = new string[] { };

        protected void AddFormulas(IEnumerable<Formula> newFormulas) 
            => formulas.AddRange(newFormulas);

        public Formula PickFormula()
        {
            var randomIndex = new Random().Next(formulas.Count);
            return formulas[randomIndex];
        }
    }
}
