using MAPMAClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPMAClient.EmpRef;

namespace MAPMAClient.ServiceLayer {
    class EmpServices {

        public EmpServices() {
        
        }

        public MAPMAClient.Model.Employee Get(int id) {
            IEmplyeeServices Service = new EmplyeeServicesClient();
            try {

                var Employee = Service.Get(id);

                MAPMAClient.Model.Employee Emp;

                Emp = GetEmployeeClientSide(Employee);

                return Emp;
            }
            catch (NullReferenceException NE) {
                Console.WriteLine(NE);
                Console.ReadLine();
                return null;
            }
        }  

        private Model.Employee GetEmployeeClientSide(EmpRef.Employee employee) {
            MAPMAClient.Model.Employee emp;

            emp = new MAPMAClient.Model.Employee {
                Address = employee.address,
                CityName = employee.cityName,
                EmployeeID = employee.employeeID,
                FirstName = employee.firstName,
                LastName = employee.lastName,
                Mail = employee.mail,
                Phone = employee.phone,
                Region = employee.region,
                Zipcode = employee.zipcode
            };

            return emp;
                
        }
    }
}