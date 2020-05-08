using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPMAClient.BookRef;

namespace MAPMAClient.ServiceLayer {
    class BookServices {

        public BookServices() {
        
        }

        public void Create(MAPMAClient.Model.Booking book) {
            IBookingServices Service = new BookingServicesClient();

            Service.Create(book.Emp.EmployeeID, book.Cus.Username, book.Er.EscapeRoomID, book.BookingTime, book.AmountOfPeople, book.Date);
        }

        public void Delete(MAPMAClient.Model.Booking book) {
            IBookingServices Service = new BookingServicesClient();
            Service.Delete(book.Emp.EmployeeID, book.Cus.Username, book.Er.EscapeRoomID, book.BookingTime, book.AmountOfPeople, book.Date);
        }

        public MAPMAClient.Model.Booking Get(MAPMAClient.Model.Customer cus, MAPMAClient.Model.EscapeRoom esr, DateTime date) {
            IBookingServices Service = new BookingServicesClient();
            try {
                var Booking = Service.Get(esr.EscapeRoomID, cus.Username, date);

                MAPMAClient.Model.Booking book;

                book = GetClientsideBooking(Booking);

                return book;
            }
            catch (NullReferenceException NE) {
                Console.WriteLine(NE);
                Console.ReadLine();
                return null;
            }

        }

        public void Update (MAPMAClient.Model.Booking book) {
            IBookingServices Service = new BookingServicesClient();

            Service.Update(book.Emp.EmployeeID, book.Cus.Username, book.Er.EscapeRoomID, book.BookingTime, book.AmountOfPeople, book.Date, book.Id);
        }

        public List<Model.Booking> GetAll() {
            IBookingServices Service = new BookingServicesClient();

            try {
                var bookings = Service.GetAll();
                return GetClientSideBooking(bookings);
            }
            catch(NullReferenceException NE) {
                Console.WriteLine(NE);
                Console.ReadLine();
                return null;
            }

        }

        private List<Model.Booking> GetClientSideBooking ( List<BookRef.Booking> bookings )
        {
            List<Model.Booking> foundbooks = new List<Model.Booking>();

            foreach (var book in bookings) {
                foundbooks.Add(GetClientsideBooking(book));
            }

            return foundbooks;
        }

        private Model.Booking GetClientsideBooking(BookRef.Booking booking) {
            MAPMAClient.Model.Booking book;
            MAPMAClient.Model.Customer cus;
            MAPMAClient.Model.Employee emp;
            MAPMAClient.Model.EscapeRoom er;

            cus = new MAPMAClient.Model.Customer {
                CustomerNo = booking.cus.customerNo,
                FirstName = booking.cus.firstName,
                LastName = booking.cus.lastName,
                Mail = booking.cus.mail,
                Phone = booking.cus.phone,
                Username = booking.cus.username
            };

            emp = new MAPMAClient.Model.Employee {
                Address = booking.emp.address,
                CityName = booking.emp.cityName,
                EmployeeID = booking.emp.employeeID,
                FirstName = booking.emp.firstName,
                LastName = booking.emp.lastName,
                Mail = booking.emp.mail,
                Phone = booking.emp.phone,
                Region = booking.emp.region,
                Zipcode = booking.emp.zipcode
            };

            er = new MAPMAClient.Model.EscapeRoom {
                CheckList = booking.er.checkList,
                CleanTime = booking.er.cleanTime,
                Description = booking.er.description,
                EscapeRoomID = booking.er.escapeRoomID,
                MaxClearTime = booking.er.maxClearTime,
                Name = booking.er.name,
                Price = booking.er.price,
                Rating = booking.er.rating
            };

            book = new MAPMAClient.Model.Booking {
                AmountOfPeople = booking.amountOfPeople,
                BookingTime = booking.bookingTime,
                Cus = cus,
                Date = booking.date,
                Emp = emp,
                Er = er,
                Id = booking.Id
                };

            return book;
        }
    }
}
