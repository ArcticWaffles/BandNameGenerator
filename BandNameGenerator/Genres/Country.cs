namespace BandNameGenerator.Genres
{
    public class Country : Genre
    {
        public Country()
        {
            SingularNouns = new[]
            {
                "Beer",
                "Boot",
                "Buck",
                "Cabin",
                "Creek",
                "Critter",
                "Dawn",
                "Drink",
                "Fire",
                "Flood",
                "Friend",
                "Hat",
                "Heart",
                "Hearth",
                "Hill",
                "Home",
                "Horse",
                "Hound",
                "Howl",
                "Jacket",
                "Mare",
                "Mile",
                "Mountain",
                "Mud",
                "Pal",
                "Pine",
                "Porch Swing",
                "Porch",
                "Prairie",
                "Ranch",
                "Saddle",
                "Saloon",
                "Song",
                "Stampede",
                "Star",
                "Town",
                "Train",
                "Whiskey",
                "Whistle",
                "Wind",
            };

            PluralNouns = new[]
            {
                "Boots",
                "Bucks",
                "Cabins",
                "Cattle",
                "Creeks",
                "Critters",
                "Fires",
                "Floods",
                "Friends",
                "Hats",
                "Hearts",
                "Hills",
                "Horses",
                "Hounds",
                "Howls",
                "Jackets",
                "Mares",
                "Miles",
                "Mountains",
                "Pals",
                "Pines",
                "Plains",
                "Porch Swings",
                "Porches",
                "Prairies",
                "Ranches",
                "Saddles",
                "Saloons",
                "Songs",
                "Stampedes",
                "Stars",
                "Trains",
                "Whistles",
                "Winds",
            };

            Adjectives = new[]
            {
                "Desert",
                "Deserted",
                "Dry",
                "Dusty",
                "Lazy",
                "Leather",
                "Lil'",
                "Lonesome",
                "Loyal",
                "Mighty",
                "Missing",
                "Moonlit",
                "Muddy",
                "Ol'",
                "Rainy",
                "Resting",
                "Rusty",
                "Thundering",
                "Whistling",
                "Windy",
                "Wishful",
                "Wondering",
            };

            ThirdPersonSingularVerbs = new[]
            {
                "Camps",
                "Dances",
                "Drives",
                "Forgets",
                "Misses",
                "Rests",
                "Rides",
                "Sings",
                "Sleeps",
                "Whistles",
            };

            ThirdPersonPluralVerbs = new[]
            {
                "Camp",
                "Dance",
                "Drive",
                "Forget",
                "Miss",
                "Recollect",
                "Rest",
                "Ride",
                "Sing",
                "Sleep",
                "Whistle",
            };

            TransitiveVerbs = new[]
            {
                "Sing",
                "Lasso",
                "Need",
                "Give",
            };

            formulas.AddRange(new[]
            {
                SharedFormulas.NumberPluralNoun,
                SharedFormulas.TransitiveVerbMeASingularNoun,
                SharedFormulas.PluralNounDontVerb,
                SharedFormulas.AdjectivePluralNounDontVerb,
                SharedFormulas.NumberAdjectivePluralNoun
            });
        }
    }
}
