using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMA.Model
{
    public class Employee : Person
    {
        public string Address { get ; set; }
        public int Zipcode { get; set ; }
        public string CityName { get ; set; }
        public string Region { get ; set ; }
        public int EmployeeID { get; set; }

        public Employee(string Address, int ZipCode, string CityName, int EmployeeID, string FirstName, string LastName, string Mail, string Phone) : base(FirstName, LastName, Mail, Phone)
        {
            this.Address = Address;
            this.Zipcode = ZipCode;
            this.CityName = CityName;
            this.Region = Region;
            this.EmployeeID = EmployeeID;
        }

        public Employee() {

        }
    }
}
