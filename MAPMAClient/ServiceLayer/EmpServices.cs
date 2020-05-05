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

        public List<MAPMAClient.Model.Employee> GetAllEmployees() {
            IEmplyeeServices Services = new EmplyeeServicesClient();

            var employees = Services.GetAll();
            return GetEmployeeClientSide(employees);
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

        private List<MAPMAClient.Model.Employee> GetEmployeeClientSide(IEnumerable<EmpRef.Employee> employees) {
            List<MAPMAClient.Model.Employee> foundEmp = new List<MAPMAClient.Model.Employee>();
            MAPMAClient.Model.Employee emp;

            foreach (var Emp in employees) {
                emp = new MAPMAClient.Model.Employee {
                    Address = Emp.address,
                    CityName = Emp.cityName,
                    EmployeeID = Emp.employeeID,
                    FirstName = Emp.firstName,
                    LastName = Emp.lastName,
                    Mail = Emp.mail,
                    Phone = Emp.phone,
                    Region = Emp.region,
                    Zipcode = Emp.zipcode
                };

                foundEmp.Add(emp);
            }
            return foundEmp;
        }
    }
}