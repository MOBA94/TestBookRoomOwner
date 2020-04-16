using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Model {
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

        public Person(string firstName, string lastName, string mail, string phone) {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Mail = mail;
            this.Phone = phone;
        }

        public Person() {

        }
    }
}
