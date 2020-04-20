using MAPMAClient.Model;
using MAPMAClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPMAClient.EscRef;
using MAPMAClient.ServiceLayer;

namespace MAPMAClient.Controller {
    public class EscapeRoomCtr {

        private EscapeRoomServices ERS;

        public EscapeRoomCtr() {

            ERS = new EscapeRoomServices();
        }

        public EscapeRoom GetForOwner(int ER_ID) {

            return ERS.GetForOwner(ER_ID);
        }

        public List<MAPMAClient.Model.EscapeRoom> GetAllForOwner() {
            return ERS.GetAllForOwner();
        }


        public void CreateEscapeRoom(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId) {
               EscapeRoomServices escService = new EscapeRoomServices();
            rating = 0;
            escService.CreateEscapeRoom(name, description, maxClearTime, cleanTime, price, rating, empId);
        }

        public List<EscapeRoom> GetAllEscapeRooms() {
            EscapeRoomServices escService = new EscapeRoomServices();
            return escService.GetAllForOwner();
        }
    }
}
