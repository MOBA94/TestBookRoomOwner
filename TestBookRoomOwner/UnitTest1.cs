using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MAPMAClient.Model;
using MAPMAClient.Controller;


namespace TestBookRoomOwner
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBookRoomOwner()
        {
            //Arrange 
            bool roomBooked = false;
            BookingCtr bc = new BookingCtr();
            CustomerCtr cc = new CustomerCtr();
            EscapeRoomCtr ec = new EscapeRoomCtr();
            EmployeeCtr emc = new EmployeeCtr();
            Customer cus = cc.Get("W84me");
            EscapeRoom er = ec.GetForOwner(2);
            Employee em = emc.Get(1);
            Booking book = new Booking() {
                AmountOfPeople = 7,
                BookingTime = DateTime.Now,
                Cus = cus,
                Date = DateTime.Now.AddDays(7.0),
                Emp = em,
                Er = er
            
            };


            ////Act
            bc.Create(book.Emp,book.Cus,book.Er,book.BookingTime,book.AmountOfPeople,book.Date);

            ////Assert
            Assert.Equals(book, bc.Find(cus,er, book.Date));

            bc.Delete(cus, er, book.Date);

        }
    }
}
