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
    public class Employee : Person {

        /// <summary>
        /// Get and set for Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Get and set for Zipcode
        /// </summary>
        public int Zipcode { get; set; }

        /// <summary>
        /// Get and set for CityName
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// Get and set for Region
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Get and set for EmployeeID
        /// </summary>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Constructor for Employee with the following parameters
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="ZipCode"></param>
        /// <param name="CityName"></param>
        /// <param name="EmployeeID"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Mail"></param>
        /// <param name="Phone"></param>
        public Employee(string Address, int ZipCode, string CityName, int EmployeeID, string FirstName, string LastName, string Mail, string Phone) : base(FirstName, LastName, Mail, Phone) {
            this.Address = Address;
            this.Zipcode = ZipCode;
            this.CityName = CityName;
            this.Region = Region;
            this.EmployeeID = EmployeeID;
        }

        /// <summary>
        /// Empty constructor for Employee
        /// </summary>
        public Employee() {
        }
    }

}
