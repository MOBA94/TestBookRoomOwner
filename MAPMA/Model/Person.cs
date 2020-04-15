using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMA.Model
{
    public abstract class Person {
        public string FirstName {
            get; set;
        }

        
        public string LastName {
            get; set;
        }

        
        public string Mail {
            get; set;
        }

        
        public string Phone {
            get; set;
        }

        public Person(string FirstName, string LastName, string Mail, string Phone) {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Mail = Mail;
            this.Phone = Phone;
        }

        public Person() {

        }
    }
}


