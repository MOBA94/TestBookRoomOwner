using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPMAClient.EscRef;
using ServiceLayer = MAPMAClient.EscRef;

namespace MAPMAClient.ServiceLayer {
    public class EscapeRoomServices {

        public EscapeRoomServices() {
        
        }

        public List<MAPMAClient.Model.EscapeRoom> GetAllForOwner() {
            IEscapeRoom_Services Service = new EscapeRoom_ServicesClient();

            var escapeRooms = Service.GetAllForOwner();
            return GetClintsideEscapeRooms(escapeRooms);
        }

        public MAPMAClient.Model.EscapeRoom GetForOwner(int ER_ID) {
            IEscapeRoom_Services Service = new EscapeRoom_ServicesClient();
            try {
                var escapeRooms = Service.GetForOwner(ER_ID);

                MAPMAClient.Model.EscapeRoom es;

                es = GetClientsideOneEscapeRoom(escapeRooms);

                return es;
            }
            catch (NullReferenceException NE) {
                Console.WriteLine(NE);
                Console.ReadLine();
                return null;
            }


        }
        public void CreateEscapeRoom(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, byte[] img) {
            IEscapeRoom_Services Service = new EscapeRoom_ServicesClient();
            Service.CreateEscapeRoom(name, description, maxClearTime, cleanTime, price, rating, empId, img);
            
        }

        public void DeleteEscapeRoom(int id) {
            IEscapeRoom_Services Service = new EscapeRoom_ServicesClient();
            Service.DeleteEscapeRoom(id);
        }

        public void UpdateEscapeRoom(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, int escId, byte[] img) {
            IEscapeRoom_Services Service = new EscapeRoom_ServicesClient();
            Service.Update(name, description, maxClearTime, cleanTime, price, rating, empId, escId, img);
        }

        private MAPMAClient.Model.EscapeRoom GetClientsideOneEscapeRoom(EscapeRoom escapeRoom) {
            MAPMAClient.Model.EscapeRoom es;

            es = new MAPMAClient.Model.EscapeRoom {
                CleanTime = escapeRoom.cleanTime,
                Description = escapeRoom.description,
               EscapeRoomID = escapeRoom.escapeRoomID,
                MaxClearTime = escapeRoom.maxClearTime,
                Name = escapeRoom.name,
                Price = escapeRoom.price,
                Rating = escapeRoom.rating,
                Image = escapeRoom.Image
               
            };

            return es;
        }

        public List<TimeSpan> FreeTimes(int ER_ID, DateTime Bdate) {
            IEscapeRoom_Services Service = new EscapeRoom_ServicesClient();

            return Service.FreeTimes(ER_ID, Bdate);
        }


        private List<MAPMAClient.Model.EscapeRoom> GetClintsideEscapeRooms(IEnumerable<EscapeRoom> escapeRooms) {
            List<MAPMAClient.Model.EscapeRoom> foundEsc = new List<MAPMAClient.Model.EscapeRoom>();
            MAPMAClient.Model.EscapeRoom es;
            MAPMAClient.Model.Employee emp;

            foreach (var ER in escapeRooms) {
                emp = new MAPMAClient.Model.Employee {
                    Address = ER.emp.address,
                    CityName = ER.emp.cityName,
                    EmployeeID = ER.emp.employeeID,
                    FirstName = ER.emp.firstName,
                    LastName = ER.emp.lastName,
                    Mail = ER.emp.mail,
                    Phone = ER.emp.phone,
                    Region = ER.emp.region,
                    Zipcode = ER.emp.zipcode
                };

                es = new MAPMAClient.Model.EscapeRoom {
                    CleanTime = ER.cleanTime,
                    Description = ER.description,
                    EscapeRoomID = ER.escapeRoomID,
                    MaxClearTime = ER.maxClearTime,
                    Name = ER.name,
                    Price = ER.price,
                    Rating = ER.rating,
                    Emp = emp,
                    Image = ER.Image
                };

                foundEsc.Add(es);

            }
            return foundEsc;
        }

    }

}
