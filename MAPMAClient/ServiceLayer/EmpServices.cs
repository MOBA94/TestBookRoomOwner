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

        public List<MAPMAClient.Model.Employee> GetAll() {
            IEmplyeeServices Service = new EmplyeeServicesClient();

            var employees = Service.GetAll();
            return GetClientsideEmployees(employees);
        }

        private List<Model.Employee> GetClientsideEmployees(IEnumerable<EmpRef.Employee> employees) {
            List<Model.Employee> foundEmp = new List<Model.Employee>();
            Model.Employee emp;

            foreach (var emps in employees) {
                emp = new MAPMAClient.Model.Employee {
                    Address = emps.address,
                    CityName = emps.cityName,
                    EmployeeID = emps.employeeID,
                    FirstName = emps.firstName,
                    LastName = emps.lastName,
                    Mail = emps.mail,
                    Phone = emps.phone,
                    Region = emps.region,
                    Zipcode = emps.zipcode
                };
                foundEmp.Add(emp);
            }
            return foundEmp;
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