﻿using System;
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
            BookingCtr bc = new BookingCtr();
            CustomerCtr cc = new CustomerCtr();
            EscapeRoomCtr ec = new EscapeRoomCtr();
            EmployeeCtr emc = new EmployeeCtr();
            MAPMAClient.Model.Customer cus = cc.Get("Anorak");
            MAPMAClient.Model.EscapeRoom er = ec.GetForOwner(2);
            MAPMAClient.Model.Employee em = emc.Get(1);
            MAPMAClient.Model.Booking book = new MAPMAClient.Model.Booking() {
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
            Assert.AreEqual(book, bc.Get(cus,er, book.Date));

            bc.Delete(cus, er, book.Date);

        }
    }
}
