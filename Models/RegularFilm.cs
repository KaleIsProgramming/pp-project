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
            string info = $"Film: {Name}\n" +
                          $"Rok: {YearOfCreation}\n" +
                          $"Reżyser: {Director}\n" +
                          $"Gatunek: {Genre}";

            MessageBox.Show(
                info,
                "Informacje o Filmie",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
