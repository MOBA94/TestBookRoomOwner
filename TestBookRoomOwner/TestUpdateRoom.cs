using System;
using MAPMAClient.Controller;
using MAPMAClient.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBookRoomOwner {
    [TestClass]
    public class TestUpdateRoom {
        
        [TestMethod]
        public void TestUpdate() {
            
            //Arrange
            EscapeRoomCtr esrCtr = new EscapeRoomCtr();
            EmployeeCtr empCtr = new EmployeeCtr();
            EscapeRoom Er = new EscapeRoom() {
                Description = "You know I Know I Still got it",
                MaxClearTime = 90,
                CleanTime = 30,
                Name = "The best",
                Price = 300,
                Rating = 5,
                Emp = empCtr.Get(2)
            };

            //Act
            esrCtr.CreateEscapeRoom(Er.Name, Er.Description, Er.MaxClearTime, Er.CleanTime, Er.Price, Er.Rating, Er.Emp.EmployeeID, Er.Image);
            EscapeRoom TestEr = esrCtr.GetForOwner(esrCtr.GetAllForOwner().Count);
            esrCtr.UpdateEscapeRoom("The best", "I am the best", 200, 20, 500, 5, Er.Emp.EmployeeID, TestEr.EscapeRoomID);
            TestEr = esrCtr.GetForOwner(esrCtr.GetAllForOwner().Count);

            //Assert
            Assert.AreEqual(Er.Name, TestEr.Name);
            Assert.AreNotEqual(Er.Description, TestEr.Description);

        }
    }
}
