using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPMAClient.BookRef;
using MAPMAClient.Model;

namespace MAPMAClient.ServiceLayer {
    class BookServices {

        public BookServices() {
        
        }

        public void Create(Booking book) {
            IBookingServices Service = new BookingServicesClient();

            Service.Create(book.Emp.EmployeeID, book.Cus.Username, book.Er.EscapeRoomID, book.BookingTime, book.AmountOfPeople, book.Date);
        }

        public void Delete(Customer cus, EscapeRoom esr, DateTime date) {
            IBookingServices Service = new BookingServicesClient();

            
        }

        public Booking Find(Customer cus, EscapeRoom esr, DateTime date) {
            IBookingServices Service = new BookingServicesClient();

            return null;
        }
    }
}
