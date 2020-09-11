using BandNameGenerator.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandNameGenerator
{
    public class ViewModel
    {
        public enum Genre
        {
            Metal,
            Country,
            Folk
        }

        public ViewModel()
        {
        }

        private Genre selectedGenre = Genre.Metal;
        public Genre SelectedGenre
        {
            get
            {
                return selectedGenre;
            }
            set
            {
                selectedGenre = value;
                BandName = "";
            }
        }

        public string BandName { get; set; }

        public void GenerateName()
        {
            BandName = "Best band name evah";
        }

        private IGenre convertToIGenre(Genre genre)
        {
            return genre switch
            {
                Genre.Metal => new Metal(),
                Genre.Country => new Country(),
                Genre.Folk => new Folk(),
                _ => new Metal(),
            };
        }
    }
}
