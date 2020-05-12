﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAPMAClient.Model;
using MAPMAClient.Controller;
using System.IO;
using System.Windows.Media.Imaging;

namespace MAPMAClient.GUI {
    public partial class Update_Room : Form {

        private EmployeeCtr EmpCtr;
        private EscapeRoomCtr ERctr;
        private EscapeRoom ER;
        private Employee Emp;
        private List<Employee> employees;

        public Update_Room(EscapeRoom esr) {
            InitializeComponent();
            EmpCtr = new EmployeeCtr();
            ERctr = new EscapeRoomCtr();
            ER = esr;
            FillTextBoxEscapeRoom(ER);
            FillLabelsEmployee(ER.Emp);
            cobEmployeeLoad();
        }

        private void cobEmployeeLoad() {
            employees = new List<Employee>();
            employees = EmpCtr.GetAll();
            cobEmployeeName.Items.Clear();

            foreach (Employee emp in employees) {
                cobEmployeeName.Items.Add(emp.FirstName + " " + emp.LastName);
            }
            cobEmployeeName.SelectedItem = ER.Emp.FirstName + " " + ER.Emp.LastName;
        }

        private Image ByteArrayToImage ( byte[] byteArrayIn )
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                var Imager = Image.FromStream(ms);

                return Imager;
            }
        }

        byte[] ConvertImgToBinary(Image img) {

            using (MemoryStream ms = new MemoryStream()) {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }

        private void FillTextBoxEscapeRoom(EscapeRoom esr) {
            string cleanTime = Convert.ToString(esr.CleanTime);
            txbCleanTime.Text = cleanTime;
            string clearTime = Convert.ToString(esr.MaxClearTime);
            txbMaxClearTime.Text = clearTime;
            txbDescription.Text = esr.Description;
            txbName.Text = esr.Name;
            string price = Convert.ToString(esr.Price);
            txbPrice.Text = price;
            pbEscapeRoom.Image = ByteArrayToImage(esr.Image);
        }

        private void FillLabelsEmployee(Employee emp) {
            lblFillEmpAddress.Text = emp.Address;
            lblFillEmpMail.Text = emp.Mail;
            lblFillEmpPhone.Text = emp.Phone;
            string zipcode = Convert.ToString(emp.Zipcode);
            lblFillEmpZipcode.Text = zipcode;
        }

        private void cobEmployeeName_SelectedIndexChanged(object sender, EventArgs e) {
            bool found = false;
            int i = 0;
            Emp = new Employee();

            while (i < employees.Count && !found) {
                string name = employees.ElementAt(i).FirstName + " " + employees.ElementAt(i).LastName;
                if (name.Equals(cobEmployeeName.SelectedItem)) {
                    Emp = employees.ElementAt(i);
                    found = true;
                }
                else {
                    i++;
                }
            }
            FillLabelsEmployee(Emp);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            CreateEscapeRoom cer = new CreateEscapeRoom();
            cer.Show(); 
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e) {
            string name = txbName.Text;
            string description = txbDescription.Text;
            decimal maxClearTime = Convert.ToDecimal(txbMaxClearTime.Text);
            decimal cleanTime = Convert.ToDecimal(txbCleanTime.Text);
            decimal price = Convert.ToDecimal(txbPrice.Text);
            //skal laves om når vi har mere rating indover
            decimal rating = 0;
            int empID;
            if (Emp == null) {
                empID = ER.Emp.EmployeeID;
            }
            else {
                empID = Emp.EmployeeID;
            }
            byte[] img;
            if (ER.Image == null) {
                img = ConvertImgToBinary(pbEscapeRoom.Image);
            }
            else {
                img = ER.Image;
            }
            ERctr.UpdateEscapeRoom(name, description, maxClearTime, cleanTime, price, rating, empID, ER.EscapeRoomID, img);
            this.Hide();
            CreateEscapeRoom cer = new CreateEscapeRoom();
            cer.Show();
        }

        private void txbPrice_TextChanged(object sender, EventArgs e) {
            try {
                decimal.Parse(txbPrice.Text);
            }
            catch(FormatException FE) {
                txbPrice.Text = "";
                //lblErrorPrice.Visible = true;
            }
        }

        private void txbMaxClearTime_TextChanged(object sender, EventArgs e) {
            try {
                decimal.Parse(txbMaxClearTime.Text);
            }
            catch (FormatException FE) {
                txbMaxClearTime.Text = "";
                lblErrorClearTime.Visible = true;
            }
        }

        private void txbCleanTime_TextChanged(object sender, EventArgs e) {
            try {
                decimal.Parse(txbCleanTime.Text);
            }
            catch (FormatException FE) {
                txbCleanTime.Text = "";
                lblErrorCleanTime.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = ER.EscapeRoomID;
            ERctr.Delete(id);

            
        }

        private void btnFindPicture_Click ( object sender, EventArgs e )
        {
            string fileName;
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    pbEscapeRoom.Image = Image.FromFile(fileName);
                    ER.Image = null;
                }
            }
        }
    }
}
