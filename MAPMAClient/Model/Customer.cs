using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Model 
    {
    public class Customer : Person 
    {
        public int CustomerNo 
        {
            get; set;
        }

        public string Password 
        {
            get; set;
        }

        public string Username 
        {
            get; set;
        }

        public Customer(int customerNo, string password, string username, string FirstName, string LastName, string Mail, string Phone) : base(FirstName, LastName, Mail, Phone)
        {
            this.CustomerNo = customerNo;
            this.Password = password;
            this.Username = username;
        }

        public Customer(string password, string username, string FirstName, string LastName, string Mail, string Phone) : base(FirstName, LastName, Mail, Phone)
        {
            this.Password = password;
            this.Username = username;
        }

        public Customer() 
        {
        }
    }
}