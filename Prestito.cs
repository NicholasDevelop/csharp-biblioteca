using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestito
    {
        public string rentalDate { get; set; }
        public string returnDate { get; set; }

        public Prestito(string rentalDate, string returnDate)
        {
            this.rentalDate = rentalDate;
            this.returnDate = returnDate;
        }

        public void Search()
        {

        }
    }

}
