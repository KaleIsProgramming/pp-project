using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_PO.Models
{
    internal class MusicAlbum : Media
    {
        public int NumOfSongs { get; set; } = 0;
        public string Producer { get; set; } = string.Empty;
    }
}
