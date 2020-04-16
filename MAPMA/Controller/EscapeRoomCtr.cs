using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer = MAPMAServiceLayers;
using MAPMA.Model;
using System.ServiceModel;
using System.Runtime.Serialization;


namespace MAPMA.Controller
{
    class EscapeRoomCtr
    {

        //public IEnumerable<EscapeRoom> GetAllForOwner() {
        //    ServiceLayer.EscRef.IEscapeRoom_Services Service = new ServiceLayer.EscRef.EscapeRoom_ServicesClient();
        //    List<EscapeRoom> ERList = new List<EscapeRoom>();
        //    EscapeRoom tempER;

        //    foreach (var ER in Service.GetAllForOwner()) {
        //        tempER = new EscapeRoom {
        //            CleanTime = ER.cleanTime,
        //            Description = ER.description,
        //            EscapeRoomID = ER.escapeRoomID,
        //            MaxClearTime = ER.maxClearTime,
        //            Name = ER.name,
        //            Price = ER.price,
        //            Rating = ER.rating
        //        };

        //        ERList.Add(tempER);
        //    }
        //    return ERList;
        //}

        //public EscapeRoom GetForOwner(int ER_ID) {
        //    ServiceLayer.EscRef.IEscapeRoom_Services Service = new ServiceLayer.EscRef.EscapeRoom_ServicesClient();
        //    EscapeRoom ER;
        //    Service.GetForOwner(ER_ID);
        //    return ER;
        //}

        public List<EscapeRoom> GetAllForOwner() {
            ServiceLayer.EscRef.IEscapeRoom_Services Service = new ServiceLayer.EscRef.EscapeRoom_ServicesClient();

            var escapeRooms = Service.GetAllForOwner();
            return GetClintsideEscapeRooms(escapeRooms);
        }

        public EscapeRoom GetForOwner(int ER_ID) {
            ServiceLayer.EscRef.IEscapeRoom_Services Service = new ServiceLayer.EscRef.EscapeRoom_ServicesClient();
            try {
                var escapeRooms = Service.GetForOwner(ER_ID);

                EscapeRoom es;

                es = GetClientsideOneEscapeRoom(escapeRooms);

                return es;
            } catch (NullReferenceException NE) {
                Console.WriteLine(NE);
                Console.ReadLine();
                return null;
            }

            
        }

        private EscapeRoom GetClientsideOneEscapeRoom(ServiceLayer.EscRef.EscapeRoom escapeRoom) {
            EscapeRoom es;

                es = new EscapeRoom {
                    CleanTime = escapeRoom.cleanTime,
                    Description = escapeRoom.description,
                    EscapeRoomID = escapeRoom.escapeRoomID,
                    MaxClearTime = escapeRoom.maxClearTime,
                    Name = escapeRoom.name,
                    Price = escapeRoom.price,
                    Rating = escapeRoom.rating
                };

            return es;
        }


        private List<EscapeRoom> GetClintsideEscapeRooms(IEnumerable<ServiceLayer.EscRef.EscapeRoom> escapeRooms) {
            List<EscapeRoom> foundEsc = new List<EscapeRoom>();
            EscapeRoom es;

            foreach (var ER in escapeRooms) {
                es = new EscapeRoom {
                    CleanTime = ER.cleanTime,
                    Description = ER.description,
                    EscapeRoomID = ER.escapeRoomID,
                    MaxClearTime = ER.maxClearTime,
                    Name = ER.name,
                    Price = ER.price,
                    Rating = ER.rating
                };

                foundEsc.Add(es);

            }
            return foundEsc;
        }
    }

}
