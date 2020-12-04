using BandNameGenerator.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandNameGenerator
{
    public class ViewModel
    {
        public enum GenreID
        {
            Metal,
            Country,
            Folk
        }

        private GenreID selectedGenre = GenreID.Metal;
        public GenreID SelectedGenre
        {
            get => selectedGenre;
            set
            {
                selectedGenre = value;
                BandName = "";
            }
        }

        public string BandName { get; set; }

        public void GenerateName()
        {
            var genre = GetNewGenre(selectedGenre);
            BandName = genre.GenerateName();
        }

        private Genre GetNewGenre(GenreID genre)
        {
            return genre switch
            {
                GenreID.Metal => new Metal(),
                GenreID.Country => new Country(),
                GenreID.Folk => new Folk(),
                _ => new Metal(),
            };
        }
    }
}
