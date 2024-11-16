using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_PO.Models
{
    public class ActionFilm : Film
    {
        private string stuntCoordinator;

        public string StuntCoordinator
        {
            get { return stuntCoordinator; }
            set { stuntCoordinator = value; }
        }

        public ActionFilm(int id, string name, int year, string director, Genre genre, string stuntCoordinator)
            : base(id, name, year, director, genre)
        {
            this.StuntCoordinator = stuntCoordinator;
        }

        public override void DisplayInfo()
        {

            string info = $"Tytuł: {Name}\n" +
              $"Rok: {YearOfCreation}\n" +
              $"Reżyser: {Director}\n" +
              $"Gatunek: {Genre}\n" +
              $"Koordynator kaskaderów: {StuntCoordinator}";

            MessageBox.Show(
                info,
                "Informacje o Filmie Akcji",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
