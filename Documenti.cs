using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documenti
    {
        public string title { get; set; }
        public string date { get; set; }
        public string genre { get; set; }
        public bool disponibility { get; set; }
        public string sectorPosition { get; set; }
        public string author { get; set; }

        public Documenti (string title, string date, string genre, bool disponibility, string sectorPosition, string author)
        {
            this.title = title;
            this.date = date;
            this.genre = genre;
            this.disponibility = disponibility;
            this.sectorPosition = sectorPosition;
            this.author = author;
        }
    }
}
