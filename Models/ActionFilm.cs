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
            private set { stuntCoordinator = value; }
        }

        public ActionFilm(int id, string name, int year, string director, Genre genre, string stuntCoordinator)
            : base(id, name, year, director, genre)
        {
            this.StuntCoordinator = stuntCoordinator;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"ID Filmu: {Id}");
            Console.WriteLine($"Tytuł: {Name}");
            Console.WriteLine($"Rok: {YearOfCreation}");
            Console.WriteLine($"Reżyser: {Director}");
            Console.WriteLine($"Gatunek: {Genre}");
            Console.WriteLine($"Koordynator kaskaderów: {StuntCoordinator}");
        }
    }
}
