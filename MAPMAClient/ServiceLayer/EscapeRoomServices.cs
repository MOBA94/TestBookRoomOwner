using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPMAClient.EscRef;
using ServiceLayer = MAPMAClient.EscRef;

namespace MAPMAClient.ServiceLayer {
    public class EscapeRoomServices {
        public List<EscapeRoom> GetAllForOwner() {
            IEscapeRoom_Services Service = new EscapeRoom_ServicesClient();

            var escapeRooms = Service.GetAllForOwner();
            return GetClintsideEscapeRooms(escapeRooms);
        }

        public EscapeRoom GetForOwner(int ER_ID) {
            IEscapeRoom_Services Service = new EscapeRoom_ServicesClient();
            try {
                var escapeRooms = Service.GetForOwner(ER_ID);

                EscapeRoom es;

                es = GetClientsideOneEscapeRoom(escapeRooms);

                return es;
            }
            catch (NullReferenceException NE) {
                Console.WriteLine(NE);
                Console.ReadLine();
                return null;
            }


        }

        private EscapeRoom GetClientsideOneEscapeRoom(EscapeRoom escapeRoom) {
            EscapeRoom es;

            es = new EscapeRoom {
                cleanTime = escapeRoom.cleanTime,
                description = escapeRoom.description,
               escapeRoomID = escapeRoom.escapeRoomID,
                maxClearTime = escapeRoom.maxClearTime,
                name = escapeRoom.name,
                price = escapeRoom.price,
                rating = escapeRoom.rating
            };

            return es;
        }


        private List<EscapeRoom> GetClintsideEscapeRooms(IEnumerable<EscapeRoom> escapeRooms) {
            List<EscapeRoom> foundEsc = new List<EscapeRoom>();
            EscapeRoom es;

            foreach (var ER in escapeRooms) {
                es = new EscapeRoom {
                    cleanTime = ER.cleanTime,
                    description = ER.description,
                    escapeRoomID = ER.escapeRoomID,
                    maxClearTime = ER.maxClearTime,
                    name = ER.name,
                    price = ER.price,
                    rating = ER.rating
                };

                foundEsc.Add(es);

            }
            return foundEsc;
        }
    }

}
