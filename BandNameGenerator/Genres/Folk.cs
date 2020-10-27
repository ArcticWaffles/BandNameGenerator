using System.Collections.Generic;

namespace BandNameGenerator.Genres
{
    public class Folk : Genre
    {
        public Folk()
        {
            SingularNouns = new[] 
            {
                "Autumn",
                "Castle",
                "Change",
                "Cloud",
                "Dance",
                "Evening",
                "Flood",
                "Friend",
                "Harvest",
                "Ivy",
                "Leaf",
                "Love",
                "Memory",
                "Midnight",
                "Mind",
                "Moon",
                "Mouse",
                "Ocean",
                "Past",
                "Path",
                "Poet",
                "Rain",
                "River",
                "Ship",
                "Snow",
                "Sojourner",
                "Song",
                "Spirit",
                "Spring",
                "Sprite",
                "Summer",
                "Thunder",
                "Time",
                "Tomorrow",
                "Traveler",
                "Twilight",
                "Valley",
                "Whale",
                "Wind",
                "Winter",
                "Year",
                "Yesterday",
            };

            PluralNouns = new[] 
            {
                "Autumns",
                "Castles",
                "Changes",
                "Clouds",
                "Dances",
                "Evenings",
                "Floods",
                "Friends",
                "Harvests",
                "Leaves",
                "Loves",
                "Memories",
                "Mice",
                "Midnights",
                "Moons",
                "Oceans",
                "Paths",
                "Poets",
                "Rains",
                "Rivers",
                "Ships",
                "Snows",
                "Songs",
                "Spirits",
                "Sprites",
                "Summers",
                "Tears",
                "Thoughts",
                "Times",
                "Tomorrows",
                "Travelers",
                "Valleys",
                "Whales",
                "Winds",
                "Winters",
                "Years",
                "Yesterdays",
            };

            Adjectives = new[]
            {
                "Blue",
                "Constant",
                "Desolate",
                "Green",
                "Icy",
                "Knitted",
                "Laughing",
                "Lively",
                "Lonely",
                "Lost",
                "Old",
                "Silver",
                "Snowy",
                "Sorrowful",
                "Timely",
                "Traveling",
                "Twilight",
                "Undone",
                "Wandering",
                "Warm",
                "Weathered",
                "Whispering",
                "Wise",
                "Young",
            };

            ThirdPersonSingularVerbs = new[]
            {
                "Catches",
                "Cries",
                "Hollers",
                "Laughs",
                "Leaps",
                "Longs",
                "Travels",
                "Wanders",
                "Whispers",
            };

            ThirdPersonPluralVerbs = new[]
            {
                "Catch",
                "Cry",
                "Holler",
                "Laugh",
                "Leap",
                "Long",
                "Travel",
                "Wander",
                "Whisper",
            };

            TransitiveVerbs = new[]
            {
                "Catch",
                "Cry",
                "Find",
                "Move",
                "Whisper",
            };

            AddFormulas(new[]
            {
                SharedFormulas.NumberPluralNoun,
                SharedFormulas.TransitiveVerbMeASingularNoun,
                SharedFormulas.TheSingularNounFrequencyVerb,
                SharedFormulas.NumberAdjectivePluralNoun
            });
        }
    }
}
