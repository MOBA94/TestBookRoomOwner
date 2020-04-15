using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


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
            Customer cus = new Customer("Mick", "Andersen", "mymail.com", "61267389");
            EscapeRoom er = new EscapeRoom("Ghost House", "Beskrivelse af rum", 750);
            Booking book = new Booking(cus, er);
            BookingController bc = new BookingController();


            //Act
            bc.BookRoomOwner(book);

            //Assert
            Assert.Equals(book, bc.FindBooking);

            bc.DeleteBooking(cus, er);

        }
    }
}
