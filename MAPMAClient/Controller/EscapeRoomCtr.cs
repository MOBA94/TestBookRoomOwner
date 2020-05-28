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
using System.Drawing;
using MAPMAClient.BookRef;
using EscapeRoom = MAPMAClient.Model.EscapeRoom;

namespace MAPMAClient.Controller {
    /// <summary>
    /// <author>
    /// Mick O. B. Andersen
    /// Anders S. Brygger
    /// Peter S. Clausen
    /// Anders B. Larsen
    /// Mads G. Ranzau
    /// </author>
    /// </summary>
    public class EscapeRoomCtr {

        private EscapeRoomServices ERS;

        /// <summary>
        /// Makes a new EscapeRoomServices named ERS
        /// </summary>
        public EscapeRoomCtr() {

            ERS = new EscapeRoomServices();
        }

        /// <summary>
        /// Gets a escaperoom from the database
        /// </summary>
        /// <param name="ER_ID"></param>
        /// <returns> One escaperoom </returns>
        public MAPMAClient.Model.EscapeRoom GetForOwner(int ER_ID) {

            return ERS.GetForOwner(ER_ID);
        }

        /// <summary>
        /// Gets all the escaperooms in the database
        /// </summary>
        /// <returns> A list of all the escaperooms</returns>
        public List<MAPMAClient.Model.EscapeRoom> GetAllForOwner() {
            return ERS.GetAllForOwner();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        byte[] ConvertImgToBinary ( Image img )
        {

            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }

        /// <summary>
        /// Creates a new escaperoom and saves it in the database
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
            if(img == null) {
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                Bitmap bm = new Bitmap(path + "\\Pictures\\MAPMA_PIC.jpg");
                byte[] Dreail = ConvertImgToBinary(bm);

                img = Dreail;
            }
            rating = 0;
            ERS.CreateEscapeRoom(name, description, maxClearTime, cleanTime, price, rating, empId, img);
        }

        /// <summary>
        /// Gets all the free bookingtimes on one escaperoom on a specific date
        /// </summary>
        /// <param name="ER_ID"></param>
        /// <param name="Bdate"></param>
        /// <returns> A list of the free bookingtimes for the date</returns>
        public List<TimeSpan> FreeTimes(int ER_ID, DateTime Bdate) {
            return ERS.FreeTimes(ER_ID, Bdate);
        }

        /// <summary>
        /// Updates a escaperoom and saves it in the database
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
            ERS.UpdateEscapeRoom(name, description, maxClearTime, cleanTime, price, rating, empId, escId, img);
        }

        /// <summary>
        /// Deletes a escaperoom in the database
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            EscapeRoom er = new EscapeRoom()
            {
                EscapeRoomID = id
            };
            ERS.DeleteEscapeRoom(id);

        }

    }
}
