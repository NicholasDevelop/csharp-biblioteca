using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Utente
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public long tel { get; set; }

        public Utente (string name, string surname, string email, string password, long tel)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
            this.tel = tel;
        }

        //public void Registration()
        //{
        //    Console.WriteLine("Inserisci il tuo nome");
        //    this.name = Console.ReadLine();
        //    Console.WriteLine("Inserisci il tuo cognome");
        //    this.surname = Console.ReadLine();
        //    Console.WriteLine("Inserisci la tua mail");
        //    this.email = Console.ReadLine();
        //    Console.WriteLine("Inserisci la password");
        //    this.password = Console.ReadLine();
        //    Console.WriteLine("Inserisci il tuo numero di telefono");
        //    this.tel = Int.Parse(Console.ReadLine());
        //}
    }
}
