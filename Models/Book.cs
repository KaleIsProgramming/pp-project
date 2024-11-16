using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_PO.Models
{
    public class Book : Media
    {
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public Book(int id, string name, int year, string author)
            : base(id, name, year)
        {
            this.Author = author;
        }
        public override void DisplayInfo()
        {
            string info = $"Tytuł: {Name}\n" +
                          $"Rok: {YearOfCreation}\n" +
                          $"Autor: {Author}";

            MessageBox.Show(
                info,
                "Informacje o książce",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
