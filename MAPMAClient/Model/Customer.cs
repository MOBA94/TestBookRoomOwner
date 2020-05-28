using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Model 
    {
    public class Customer : Person 
    {

        /// <summary>
        /// Get and set for CustomerNo
        /// </summary>
        public int CustomerNo 
        {
            get; set;
        }

        /// <summary>
        /// Get and set for Password
        /// </summary>
        public string Password 
        {
            get; set;
        }

        /// <summary>
        /// Get and set for Username
        /// </summary>
        public string Username 
        {
            get; set;
        }

        /// <summary>
        /// Constructor for Customer with the following parameters
        /// </summary>
        /// <param name="customerNo"></param>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Mail"></param>
        /// <param name="Phone"></param>
        public Customer(int customerNo, string password, string username, string FirstName, string LastName, string Mail, string Phone) : base(FirstName, LastName, Mail, Phone)
        {
            this.CustomerNo = customerNo;
            this.Password = password;
            this.Username = username;
        }

        /// <summary>
        /// Constructor for Customer with the following parameters
        /// </summary>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Mail"></param>
        /// <param name="Phone"></param>
        public Customer(string password, string username, string FirstName, string LastName, string Mail, string Phone) : base(FirstName, LastName, Mail, Phone)
        {
            this.Password = password;
            this.Username = username;
        }

        /// <summary>
        /// Empty consructor for Customer
        /// </summary>
        public Customer() 
        {
        }
    }
}