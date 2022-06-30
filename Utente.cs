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

        public void Registration()
        {

        }
    }
}
