using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_PO.Models
{
    public abstract class Media
    {
        private static int mediaCount = 0;

        public static int GetMediaCount()
        {
            return mediaCount;
        }

        private int id;           
        private string name;      
        private int yearOfCreation;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int YearOfCreation
        {
            get { return yearOfCreation; }
            set { yearOfCreation = value; }
        }

        public Media(int id, string name, int year)
        {
            this.Id = id;
            this.Name = name;
            this.YearOfCreation = year;
            mediaCount++;
        }

        public abstract void DisplayInfo();
    }
}
