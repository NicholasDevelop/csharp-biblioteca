using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Documenti
    {
        public long serialNumber { get; set; }
        public int time { get; set; }

        public Dvd(long serialNumber, int time, string title, string date, string genre, bool disponibility, string sectorPosition, string author) : base(title, date, genre, disponibility, sectorPosition, author)
        {
            this.serialNumber = serialNumber;
            this.time = time;
        }
    }
}
