using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMA.Model
{
    class Employee : Person
    {
        public string address { get => address; set => address = value; }
        public int zipcode { get => zipcode; set => zipcode = value; }
        public string cityName { get => cityName; set => cityName = value; }
        public string region { get => region; set => region = value; }
        public int employeeID { get => employeeID; set => employeeID = value; }

        public Employee(string address, int zipCode, string cityName, int employeeID, string firstName, string lastName, string mail, string phone) : base(firstName, lastName, mail, phone)
        {
            this.address = address;
            this.zipcode = zipcode;
            this.cityName = cityName;
            this.region = region;
            this.employeeID = employeeID;
        }
    }
}
