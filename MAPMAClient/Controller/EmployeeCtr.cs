using MAPMAClient.Model;
using MAPMAClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Controller {
    public class EmployeeCtr {

        private EmpServices EMPS;

        public EmployeeCtr() {

            EMPS = new EmpServices();
        }

        public Employee Get(int id) {

            return EMPS.Get(id);
        }
    }
}
