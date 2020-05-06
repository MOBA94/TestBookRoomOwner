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

        public MAPMAClient.Model.EscapeRoom GetForOwner(int ER_ID) {

            return ERS.GetForOwner(ER_ID);
        }

        public List<MAPMAClient.Model.EscapeRoom> GetAllForOwner() {
            return ERS.GetAllForOwner();
        }


        public void CreateEscapeRoom(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId) {
            rating = 0;
            ERS.CreateEscapeRoom(name, description, maxClearTime, cleanTime, price, rating, empId);
        }

        public void UpdateEscapeRoom(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, int escId) {
            ERS.UpdateEscapeRoom(name, description, maxClearTime, cleanTime, price, rating, empId, escId);
        }

    }
}
