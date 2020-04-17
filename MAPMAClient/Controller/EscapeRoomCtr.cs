using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPMAClient.ServiceLayer;

namespace MAPMAClient.Controller {
    class EscapeRoomCtr {


        public void CreateEscapeRoom(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId) {
               EscapeRoomServices escService = new EscapeRoomServices();
            rating = 0;
            escService.CreateEscapeRoom(name, description, maxClearTime, cleanTime, price, rating, empId);
        }
    }
}
