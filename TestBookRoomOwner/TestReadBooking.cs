using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MAPMAClient.Controller;
using System.Collections.Generic;
using MAPMAClient.Model;

namespace TestBookRoomOwner
{
    [TestClass]
    public class TestReadBooking
    {
        [TestMethod]
        public void ReadAllBookingTest ( )
        {
            //Arrange
            BookingCtr bc = new BookingCtr();
            List<Booking> bookings;

            //Act
            bookings = bc.GetAll();

            //Assert
            Assert.IsNotNull(bookings);
        }
    }
}
