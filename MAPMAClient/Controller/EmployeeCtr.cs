using MAPMAClient.Model;
using MAPMAClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Controller {
    /// <summary>
    /// <author>
    /// Mick O. B. Andersen
    /// Anders S. Brygger
    /// Peter S. Clausen
    /// Anders B. Larsen
    /// Mads G. Ranzau
    /// </author>
    /// </summary>
    public class EmployeeCtr {

        private EmpServices EMPS;

        /// <summary>
        /// Makes a new EmpServices named EMPS
        /// </summary>
        public EmployeeCtr() {

            EMPS = new EmpServices();
        }

        /// <summary>
        /// Gets a employee from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns> One employee </returns>
        public Employee Get(int id) {

            return EMPS.Get(id);
        }

        /// <summary>
        /// Gets all the employees from the database
        /// </summary>
        /// <returns> A list of all the employees in the database </returns>
        public List<Model.Employee> GetAll() {
            return EMPS.GetAll();
        }
    }
}
