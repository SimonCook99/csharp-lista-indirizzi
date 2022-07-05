using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzo{
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string ZIP { get; set; }

        public Indirizzo(string name, string surname, string street, string city, string province, string zIP){
            Name = name;
            Surname = surname;
            Street = street;
            City = city;
            Province = province;
            ZIP = zIP;
        }
    }
}
