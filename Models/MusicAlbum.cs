using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_PO.Models
{
    public class MusicAlbum : Media, IPlayable
    {

        private string artist;
        private Genre genre;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public Genre Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public MusicAlbum(int id, string name, int year, string artist, Genre genre)
            : base(id, name, year)
        {
            this.Artist = artist;
            this.Genre = genre;
        }

        public void Play()
        {
            Console.WriteLine($"Odtwarzanie albumu muzycznego: {Name}");
        }

        public override void DisplayInfo()
        {
            string info = $"Tytuł: {Name}\n" +
                          $"Rok: {YearOfCreation}\n" +
                          $"Artysta: {Artist}" +
                          $"Gatunek: {Genre}";

            MessageBox.Show(
                info,
                "Informacje o Albumie Muzyczne",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
