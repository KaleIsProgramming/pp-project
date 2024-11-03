using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_PO.Models
{
    public abstract class Film : Media, IPlayable
    {
        private string director;
        private Genre genre;

        public string Director
        {
            get { return director; }
            private set { director = value; }
        }

        public Genre Genre
        {
            get { return genre; }
            private set { genre = value; }
        }

        public Film(int id, string name, int year, string director, Genre genre)
            : base(id, name, year)
        {
            this.Director = director;
            this.Genre = genre;
        }

        public void Play()
        {
            Console.WriteLine($"Odtwarzanie filmu: {Name}");
        }
        public override abstract void DisplayInfo();
    }
}
