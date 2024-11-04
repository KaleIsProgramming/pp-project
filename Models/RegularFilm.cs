using System;

namespace PP_PO.Models
{
    public class RegularFilm : Film
    {
        public RegularFilm(int id, string name, int year, string director, Genre genre)
            : base(id, name, year, director, genre)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Film: {Name}, Reżyser: {Director}, Rok: {YearOfCreation}, Gatunek: {Genre}");
        }
    }
}
