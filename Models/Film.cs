using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_PO.Models
{
    internal class Film : Media
    {
        public int Duration { get; set; } = 0;
        public string Director { get; set; } = string.Empty;
    }
}
