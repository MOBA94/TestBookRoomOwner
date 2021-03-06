﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPMAClient.EscRef;
using ServiceLayer = MAPMAClient.EscRef;

namespace MAPMAClient.ServiceLayer {
    /// <summary>
    /// <author>
    /// Mick O. B. Andersen
    /// Anders S. Brygger
    /// Peter S. Clausen
    /// Anders B. Larsen
    /// Mads G. Ranzau
    /// </author>
    /// </summary>
    public class EscapeRoomServices {

        /// <summary>
        /// Empty constructor for EscapeRoomServices
        /// </summary>
        public EscapeRoomServices() {
        
        }

        /// <summary>
        /// Gets a list with all the Escaperooms in the database
        /// </summary>
        /// <returns>A list of all the escaperooms</returns>
        public List<MAPMAClient.Model.EscapeRoom> GetAllForOwner() {
            IEscapeRoom_Services Service = new EscapeRoom_ServicesClient();

            var escapeRooms = Service.GetAllForOwner();
            return GetClintsideEscapeRooms(escapeRooms);
        }

        /// <summary>
        /// Search the database for one escaperoom
        /// </summary>
        /// <param name="ER_ID"></param>
        /// <returns>One escaperoom</returns>
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

        /// <summary>
        /// Calls the WCF, so the method CreateEscapeRoom runs in the host and a escaperoom is createt and saved in the database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="maxClearTime"></param>
        /// <param name="cleanTime"></param>
        /// <param name="price"></param>
        /// <param name="rating"></param>
        /// <param name="empId"></param>
        /// <param name="img"></param>
        public void CreateEscapeRoom(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, byte[] img) {
            IEscapeRoom_Services Service = new EscapeRoom_ServicesClient();
            Service.CreateEscapeRoom(name, description, maxClearTime, cleanTime, price, rating, empId, img);
            
        }

        /// <summary>
        /// Calls the WCF, so the method DeleteEscapeRoom runs in the host and the choosen escaperoom is deletet
        /// </summary>
        /// <param name="id"></param>
        public void DeleteEscapeRoom(int id) {
            IEscapeRoom_Services Service = new EscapeRoom_ServicesClient();
            Service.DeleteEscapeRoom(id);
        }

        /// <summary>
        /// Calls the WCF, so the method UpdateEscapeRoom runs in the host and the choosen escaperoom is updatet
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="maxClearTime"></param>
        /// <param name="cleanTime"></param>
        /// <param name="price"></param>
        /// <param name="rating"></param>
        /// <param name="empId"></param>
        /// <param name="escId"></param>
        /// <param name="img"></param>
        public void UpdateEscapeRoom(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, int escId, byte[] img) {
            IEscapeRoom_Services Service = new EscapeRoom_ServicesClient();
            Service.Update(name, description, maxClearTime, cleanTime, price, rating, empId, escId, img);
        }

        /// <summary>
        /// Converts the escaperooms from the WCF into MAPMAClient.Model.EscapeRoom
        /// </summary>
        /// <param name="escapeRoom"></param>
        /// <returns>MAPMAClient.Model.EscapeRoom</returns>
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

        /// <summary>
        /// To get the FreeTimes on a choosen escaperoom on a specific date
        /// </summary>
        /// <param name="ER_ID"></param>
        /// <param name="Bdate"></param>
        /// <returns>The FreeTimes on the specific date</returns>
        public List<TimeSpan> FreeTimes(int ER_ID, DateTime Bdate) {
            IEscapeRoom_Services Service = new EscapeRoom_ServicesClient();

            return Service.FreeTimes(ER_ID, Bdate);
        }

        /// <summary>
        /// Converts the escaperooms from the WCF into a list of MAPMAClient.Model.EscapeRoom
        /// </summary>
        /// <param name="escapeRooms"></param>
        /// <returns>A list of MAPMAClient.Model.EscapeRoom</returns>
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
