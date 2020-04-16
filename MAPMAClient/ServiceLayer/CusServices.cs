using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPMAClient.CusRef;

namespace MAPMAClient.ServiceLayer {
    class CusServices {

        public CusServices() {
        
        }

        public MAPMAClient.Model.Customer Get(string username) {
            ICustomerServices Service = new CustomerServicesClient();

            try {
                var Customer = Service.Get(username);

                MAPMAClient.Model.Customer Cus;

                Cus = GetCustmerClientSide(Customer);

                return Cus;
            }
            catch (NullReferenceException NE) {
                Console.WriteLine(NE);
                Console.ReadLine();
                return null;
            }

        }

        private Model.Customer GetCustmerClientSide(CusRef.Customer customer) {
            MAPMAClient.Model.Customer cus;

            cus = new MAPMAClient.Model.Customer {
                CustomerNo = customer.customerNo,
                FirstName = customer.firstName,
                LastName = customer.lastName,
                Mail = customer.mail,
                Password = customer.password,
                Phone = customer.phone,
                Username = customer.username
            };
            return cus;
                
        }
    }
}

