using System;
using System.Collections.Generic;
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
            private set { rpm = value; }
        }

        public VinylRecord(int id, string name, int year, string artist, Genre genre, int rpm)
            : base(id, name, year, artist, genre)
        {
            this.RPM = rpm;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Obroty na minutę (RPM): {RPM}");
        }
    }
}
