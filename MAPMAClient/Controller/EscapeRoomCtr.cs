using MAPMAClient.Model;
using MAPMAClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Controller {
    class EscapeRoomCtr {

        private EscapeRoomServices ERS;

        public EscapeRoomCtr() {

            ERS = new EscapeRoomServices();
        }

        public EscapeRoom GetForOwner(int ER_ID) {

            return ERS.GetForOwner(ER_ID);
        }
    }
}
