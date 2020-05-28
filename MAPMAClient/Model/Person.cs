using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Model {
    /// <summary>
    /// <author>
    /// Mick O. B. Andersen
    /// Anders S. Brygger
    /// Peter S. Clausen
    /// Anders B. Larsen
    /// Mads G. Ranzau
    /// </author>
    /// </summary>
    public abstract class Person {

        /// <summary>
        /// Get and set for FirstName
        /// </summary>
        public string FirstName {
            get; set;
        }

        /// <summary>
        /// Get and set for LastName
        /// </summary>
        public string LastName {
            get; set;
        }

        /// <summary>
        /// Get and set for Mail
        /// </summary>
        public string Mail {
            get; set;
        }

        /// <summary>
        /// Get and set for Phone
        /// </summary>
        public string Phone {
            get; set;
        }

        /// <summary>
        /// Constructor for Person with the following parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="mail"></param>
        /// <param name="phone"></param>
        public Person(string firstName, string lastName, string mail, string phone) {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Mail = mail;
            this.Phone = phone;
        }

        /// <summary>
        /// Empty Constructor for Person
        /// </summary>
        public Person() {

        }
    }
}
