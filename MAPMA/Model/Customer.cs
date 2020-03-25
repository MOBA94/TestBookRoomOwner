using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMA.Model
{
    class Customer : Person
    {
        public int customerNo { get; set; }
        public string password { get; set; }
        public string username { get; set; }

        public Customer(string password, string username, string firstName, string lastName, string mail, string phone) : base(firstName, lastName, mail, phone)
        {
            this.password = password;
            this.username = username;
        }


    }
}
