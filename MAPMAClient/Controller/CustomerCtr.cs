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
    public class CustomerCtr {

        private CusServices CUSS;

        /// <summary>
        /// Makes a new CusServices named CUSS
        /// </summary>
        public CustomerCtr() {
            CUSS = new CusServices();
        }

        /// <summary>
        /// Gets a customer from the database
        /// </summary>
        /// <param name="username"></param>
        /// <returns> One customer </returns>
        public Customer Get(string username) {
            return CUSS.Get(username);
        }
    }
}
