using MAPMAClient.Model;
using MAPMAClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Controller {
    public class CustomerCtr {

        private CusServices CUSS;

        public CustomerCtr() {
            CUSS = new CusServices();
        }

        public Customer Get(string username) {
            return CUSS.Get(username);
        }
    }
}
