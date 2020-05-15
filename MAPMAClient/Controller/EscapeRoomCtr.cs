﻿using MAPMAClient.Model;
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

        byte[] ConvertImgToBinary ( Image img )
        {

            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }


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

        public List<TimeSpan> FreeTimes(int ER_ID, DateTime Bdate) {
            return ERS.FreeTimes(ER_ID, Bdate);
        }

        public void UpdateEscapeRoom(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, int escId, byte[] img) {
            ERS.UpdateEscapeRoom(name, description, maxClearTime, cleanTime, price, rating, empId, escId, img);
        }

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
