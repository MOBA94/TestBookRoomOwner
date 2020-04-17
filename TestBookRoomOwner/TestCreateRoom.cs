using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MAPMAClient.Model;
using MAPMAClient.ServiceLayer;



namespace TestBookRoomOwner
{
    /// <summary>
    /// Summary description for TestCreateRoom
    /// </summary>
    [TestClass]
    public class TestCreateRoom
    {
        [TestMethod]
        public void TestMethod1 ( )
        {

            //Arrange
            EscapeRoomServices ess = new EscapeRoomServices();
            MAPMAClient.EscRef.EscapeRoom Es1 = new MAPMAClient.EscRef.EscapeRoom();
            MAPMAClient.EscRef.Employee Em1 = new MAPMAClient.EscRef.Employee();
            Es1.name = "The Dark Room";
            Es1.description = "The Fors is Strong in the darkside";
            Es1.maxClearTime = 180;
            Es1.cleanTime = 90;
            Es1.price = 1200;
            Es1.rating = 0;
            Es1.emp.employeeID = Em1.employeeID = 1;



            //Act
            ess.CreateEscapeRoom(Es1.name, Es1.description, Es1.maxClearTime, Es1.cleanTime, Es1.price, Es1.rating, Es1.emp.employeeID);

            //Assert
            List<MAPMAClient.EscRef.EscapeRoom> list = ess.GetAllForOwner();

            bool found = false;            
            if (Es1.Equals(list.Contains(Es1))) {
                found = true;
            }
            Assert.IsTrue(found);
        }
    }
}
