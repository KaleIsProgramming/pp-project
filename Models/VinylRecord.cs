using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_PO.Models
{
    public class VinylRecord : MusicAlbum
    {
        private int rpm;
        public int RPM
        {
            get { return rpm; }
            set { rpm = value; }
        }

        public VinylRecord(int id, string name, int year, string artist, Genre genre, int rpm)
            : base(id, name, year, artist, genre)
        {
            this.RPM = rpm;
        }

        public override void DisplayInfo()
        {
            string info = $"Nazwa Płyty: {Name}\n" +
                          $"Rok: {YearOfCreation}\n" +
                          $"Artysta: {Artist}\n" +
                          $"RPM: {RPM}\n" +
                          $"Gatunek: {Genre}";

            MessageBox.Show(
                info,
                "Informacje o Płycie Vionylowej",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
