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
            set { director = value; }
        }

        public Genre Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public Film(int id, string name, int year, string director, Genre genre)
            : base(id, name, year)
        {
            this.Director = director;
            this.Genre = genre;
        }

        public void Play()
        {

            string info = $"Odtwarzanie filmu: {Name}\n";

            MessageBox.Show(
                info,
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        public override abstract void DisplayInfo();
    }
}
