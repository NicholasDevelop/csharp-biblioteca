using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Libro : Documenti
    {
        public long isbn { get; set; }
        public int nPages { get; set; }

        public Libro (long isbn, int nPages, string title, string date, string genre, bool disponibility, string sectorPosition, string author) : base(title, date, genre, disponibility, sectorPosition, author)
        {
            this.isbn = isbn;
            this.nPages = nPages;
        }

    }
}
