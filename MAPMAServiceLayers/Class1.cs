using MAPMAServiceLayers.EscRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAServiceLayers {
    public class Class1 {

        public IEnumerable<EscapeRoom> GetAllForOwner() {
            IEscapeRoom_Services Service = new MAPMAServiceLayers.EscRef.EscapeRoom_ServicesClient();
            List<EscapeRoom> ERList = new List<EscapeRoom>();
            EscapeRoom tempER;

            foreach (var ER in Service.GetAllForOwner()) {
                tempER = new EscapeRoom
                {
                    cleanTime = ER.cleanTime,
                    description = ER.description,
                    emp = ER.emp,
                    escapeRoomID = ER.escapeRoomID,
                    checkList = ER.checkList,
                    maxClearTime = ER.maxClearTime,
                    name = ER.name,
                    price = ER.price,
                    rating = ER.rating
                };

                ERList.Add(tempER);
            }
            return ERList;
        }

        public EscapeRoom GetForOwner(int ER_ID) {
            IEscapeRoom_Services Service = new MAPMAServiceLayers.EscRef.EscapeRoom_ServicesClient();
            EscapeRoom ER;
            ER = Service.GetForOwner(ER_ID);
            return ER;
        }
    }
}
