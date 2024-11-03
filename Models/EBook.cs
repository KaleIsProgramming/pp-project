using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_PO.Models
{
    public class EBook : Book
    {
        private string fileFormat;

        public string FileFormat
        {
            get { return fileFormat; }
            private set { fileFormat = value; }
        }

        public EBook(int id, string name, int year, string author, string fileFormat)
            : base(id, name, year, author)
        {
            this.FileFormat = fileFormat;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Format pliku: {FileFormat}");
        }
    }
}
