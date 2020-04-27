using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MAPMAClient.Model;
using MAPMAClient.ServiceLayer;
using MAPMAClient.Controller;
using System.Linq;



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
            EmployeeCtr empCtr = new EmployeeCtr();

            MAPMAClient.Model.EscapeRoom Es1 = new MAPMAClient.Model.EscapeRoom();
            MAPMAClient.Model.Employee Em1 = empCtr.Get(1);
            Es1.Name = "The Dark Room";
            Es1.Description = "The Fors is Strong in the darkside";
            Es1.MaxClearTime = 180;
            Es1.CleanTime = 90;
            Es1.Price = 1200;
            Es1.Rating = 0;
            Es1.Emp = Em1;



            //Act
            ess.CreateEscapeRoom(Es1.Name, Es1.Description, Es1.MaxClearTime, Es1.CleanTime, Es1.Price, Es1.Rating, Es1.Emp.EmployeeID);

            //Assert
            List<MAPMAClient.Model.EscapeRoom> escapeRooms = new List<MAPMAClient.Model.EscapeRoom>();
            escapeRooms = ess.GetAllForOwner();
            bool found = false;
            int i = 0;
            MAPMAClient.Model.EscapeRoom EsR = new MAPMAClient.Model.EscapeRoom();
            

            while (i < escapeRooms.Count && !found) {
                if (escapeRooms.ElementAt(i).Name.Equals(Es1.Name)) {
                    EsR = escapeRooms.ElementAt(i);
                    found = true;
                }
                else {
                    i++;
                }
            }

            Assert.IsTrue(found);

            if (EsR.EscapeRoomID != 0) {
                ess.DeleteEscapeRoom(EsR.EscapeRoomID);
            }
        }
    }
}
