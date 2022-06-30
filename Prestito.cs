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
        public List<Utente> ListaUtenti = new List<Utente>();

        public Prestito(string rentalDate, string returnDate)
        {
            this.rentalDate = rentalDate;
            this.returnDate = returnDate;

            ListaUtenti.Add(new Utente("Nicholas", "Marcaccini", "ciao@gmail.com", "prova123", 3859655672));
            ListaUtenti.Add(new Utente("Paolo", "Mistretta", "paolo@gmail.com", "prova123", 3457812545));
            ListaUtenti.Add(new Utente("Giorgio", "Rossi", "giorgio@gmail.com", "prova123", 3926599970));


            Console.WriteLine("Inserisci il tuo nome");
            string name = Console.ReadLine();

            Console.WriteLine("Inserisci il tuo cognome");
            string surname = Console.ReadLine();

            Console.WriteLine("Inserisci la tua mail");
            string email = Console.ReadLine();

            Console.WriteLine("Inserisci la password");
            string password = Console.ReadLine();

            Console.WriteLine("Inserisci il tuo numero di telefono");
            long tel = int.Parse(Console.ReadLine());
        }

        public void Search()
        {

        }
    }

}
