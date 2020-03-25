using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMA.Model
{
    public abstract class Person
    {
        public string firstName { get => firstName; set => firstName = value; }
        public string lastName { get => lastName; set => lastName = value; }
        public string mail { get => mail; set => mail = value; }
        public string phone { get => phone; set => phone = value; }

        public Person(string FirstName, string LastName, string Mail, string Phone)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.mail = Mail;
            this.phone = Phone;
        }
    }
}

