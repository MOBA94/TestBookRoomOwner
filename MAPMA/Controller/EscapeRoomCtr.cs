using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer = MAPMAServiceLayers;
using MAPMA.Model;
using System.ServiceModel;


namespace MAPMA.Controller
{
    class EscapeRoomCtr
    {

        public IEnumerable<EscapeRoom> GetAllForOwner() {
            ServiceLayer.EscRef.IEscapeRoom_Services Service = new ServiceLayer.EscRef.EscapeRoom_ServicesClient();
            List<EscapeRoom> ERList = new List<EscapeRoom>();
            EscapeRoom tempER;

            foreach (var ER in Service.GetAllForOwner()) {
                tempER = new EscapeRoom {
                    CleanTime = ER.cleanTime,
                    Description = ER.description,
                    EscapeRoomID = ER.escapeRoomID,
                    MaxClearTime = ER.maxClearTime,
                    Name = ER.name,
                    Price = ER.price,
                    Rating = ER.rating
                };

                ERList.Add(tempER);
            }
            return ERList;
        }

        //public EscapeRoom GetForOwner(int ER_ID) {
        //    ServiceLayer.EscRef.IEscapeRoom_Services Service = new ServiceLayer.EscRef.EscapeRoom_ServicesClient();
        //    EscapeRoom ER;
        //    Service.GetForOwner(ER_ID);
        //    return ER;
        //}
    }
}
