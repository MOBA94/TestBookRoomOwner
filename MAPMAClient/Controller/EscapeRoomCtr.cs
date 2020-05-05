using MAPMAClient.Model;
using MAPMAClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPMAClient.EscRef;
using MAPMAClient.ServiceLayer;
using System.IO;
using System.Windows.Forms;

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


        public void CreateEscapeRoom(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, byte[] img) {
            if(img == null) {
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                byte[] Dreail = Encoding.ASCII.GetBytes(path + "\\Pictures\\MAPMA_PIC.jpg");

                img = Dreail;
            }
            rating = 0;
            ERS.CreateEscapeRoom(name, description, maxClearTime, cleanTime, price, rating, empId, img);
        }

        public List<TimeSpan> FreeTimes(int ER_ID, DateTime Bdate) {
            return ERS.FreeTimes(ER_ID, Bdate);
        }

    }
}
