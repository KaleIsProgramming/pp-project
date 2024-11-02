using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_PO.Models
{
    public class Book : Media
    {
        public int NumberOfPages {  get; set; } = 0;
        public string Type { get; set; } = string.Empty;

    }
}
