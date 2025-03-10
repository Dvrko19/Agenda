using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Persona
    {
        public int id {  get; set; }
        public string nombre {  get; set; }
        public string email {  get; set; }
        public string phone {  get; set; }

        public string Birth {  get; set; }
        public string Gen { get; set; }
        public string city {  get; set; }

        public Persona(int id, string nombre, string email, string phone, string city) 
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.phone = phone;
            this.city = city;
        }

        public Persona()
        {

        }
    }
}
