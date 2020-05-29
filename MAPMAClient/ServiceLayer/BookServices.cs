using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPMAClient.BookRef;

namespace MAPMAClient.ServiceLayer {
    /// <summary>
    /// <author>
    /// Mick O. B. Andersen
    /// Anders S. Brygger
    /// Peter S. Clausen
    /// Anders B. Larsen
    /// Mads G. Ranzau
    /// </author>
    /// </summary>
    class BookServices {

        /// <summary>
        /// Empty constructor for BookServices()
        /// </summary>
        public BookServices() {
        
        }

        /// <summary>
        /// Calls the WCF, so the method Create runs in the host and a booking is createt and saved in the database
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int Create(MAPMAClient.Model.Booking book) {
            IBookingServices Service = new BookingServicesClient();

           return Service.Create(book.Emp.EmployeeID, book.Cus.Username, book.Er.EscapeRoomID, book.BookingTime, book.AmountOfPeople, book.Date);
        }

        /// <summary>
        /// Calls the WCF, so the method Delete runs in the host and the choosen booking is deletet
        /// </summary>
        /// <param name="book"></param>
        public void Delete(MAPMAClient.Model.Booking book) {
            IBookingServices Service = new BookingServicesClient();


            Service.Delete(book.Emp.EmployeeID, book.Cus.Username, book.Er.EscapeRoomID, book.BookingTime, book.AmountOfPeople, book.Date);
        }

        /// <summary>
        /// Search the database for one booking
        /// </summary>
        /// <param name="cus"></param>
        /// <param name="esr"></param>
        /// <param name="date"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Calls the WCF, so the method Update runs in the host and the choosen booking is updatet
        /// </summary>
        /// <param name="book"></param>
        public void Update (MAPMAClient.Model.Booking book) {
            IBookingServices Service = new BookingServicesClient();

            Service.Update(book.Emp.EmployeeID, book.Cus.Username, book.Er.EscapeRoomID, book.BookingTime, book.AmountOfPeople, book.Date, book.Id);
        }

        /// <summary>
        /// Gets a list with all the bookings in the database
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Gets all the bookings for one escaperoom in the database
        /// </summary>
        /// <param name="EscId"></param>
        /// <returns></returns>
        public List<Model.Booking> GetAllOneRoom(int EscId) {
            IBookingServices Service = new BookingServicesClient();

            try {
                var bookings = Service.GetAllOneRoom(EscId);
                return GetClientSideBooking(bookings);
            }
            catch (NullReferenceException NE) {
                Console.WriteLine(NE);
                Console.ReadLine();
                return null;
            }
        }

        /// <summary>
        /// Converts all the bookings in the list to MAPMAClient.Model.Booking
        /// </summary>
        /// <param name="bookings"></param>
        /// <returns> a list of MAPMAClient.Model.Booking </returns>
        private List<Model.Booking> GetClientSideBooking ( List<BookRef.Booking> bookings )
        {
            List<Model.Booking> foundbooks = new List<Model.Booking>();

            foreach (var book in bookings) {
                foundbooks.Add(GetClientsideBooking(book));
            }

            return foundbooks;
        }

        /// <summary>
        /// Converts one booking into MAPMAClient.Model.Booking
        /// </summary>
        /// <param name="booking"></param>
        /// <returns> MAPMAClient.Model.Booking</returns>
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
