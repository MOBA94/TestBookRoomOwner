using System;
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
    /// <summary>
    /// <author>
    /// Mick O. B. Andersen
    /// Anders S. Brygger
    /// Peter S. Clausen
    /// Anders B. Larsen
    /// Mads G. Ranzau
    /// </author>
    /// </summary>
    public partial class Update_Room : Form {

        private EmployeeCtr EmpCtr;
        private EscapeRoomCtr ERctr;
        private EscapeRoom ER;
        private Employee Emp;
        private List<Employee> employees;

        /// <summary>
        /// Opens Update_Room and runs FillTextBoxEscapeRoom(ER), FillLabelsEmployee(ER.Emp) and cobEmployeeLoad()
        /// </summary>
        /// <param name="esr"></param>
        public Update_Room(EscapeRoom esr) {
            InitializeComponent();
            EmpCtr = new EmployeeCtr();
            ERctr = new EscapeRoomCtr();
            ER = esr;
            FillTextBoxEscapeRoom(ER);
            FillLabelsEmployee(ER.Emp);
            cobEmployeeLoad();
        }

        /// <summary>
        /// Calls EmpCtr.GetAll and sets all the Employees in the combobox
        /// </summary>
        private void cobEmployeeLoad() {
            employees = new List<Employee>();
            employees = EmpCtr.GetAll();
            cobEmployeeName.Items.Clear();

            foreach (Employee emp in employees) {
                cobEmployeeName.Items.Add(emp.FirstName + " " + emp.LastName);
            }
            cobEmployeeName.SelectedItem = ER.Emp.FirstName + " " + ER.Emp.LastName;
        }

        /// <summary>
        /// Converts bytes to image 
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns> Imager </returns>
        private Image ByteArrayToImage ( byte[] byteArrayIn )
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                var Imager = Image.FromStream(ms);

                return Imager;
            }
        }

        /// <summary>
        /// Converts the image to binary
        /// </summary>
        /// <param name="img"></param>
        /// <returns> ms.ToArray() </returns>
        byte[] ConvertImgToBinary(Image img) {

            using (MemoryStream ms = new MemoryStream()) {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }

        /// <summary>
        /// Fills all the textboxes for escaperoom, with the escaperoom it has
        /// </summary>
        /// <param name="esr"></param>
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

        /// <summary>
        /// Fills all the labels with the employee info 
        /// </summary>
        /// <param name="emp"></param>
        private void FillLabelsEmployee(Employee emp) {
            lblFillEmpAddress.Text = emp.Address;
            lblFillEmpMail.Text = emp.Mail;
            lblFillEmpPhone.Text = emp.Phone;
            string zipcode = Convert.ToString(emp.Zipcode);
            lblFillEmpZipcode.Text = zipcode;
        }

        /// <summary>
        /// Finds the employee there is choosen in the combobox and rund FillLabelsEmploye(Emp)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Shows CreateEscapeRoom and hides itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            CreateEscapeRoom cer = new CreateEscapeRoom();
            cer.Show(); 
        }

        /// <summary>
        /// Checks all the textboxes for valid data then runs UpdateEscapeRoom, shows CreateEscapeRoom and hides itself
        /// it has error messages is the data is invalid 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateRoom_Click ( object sender, EventArgs e ) {

            if (txbName.Text.Equals("")) {
                txbName.Text = "Dette felt skal have en værdig";
                txbName.BackColor = Color.Red;

            }
            else if (txbDescription.Text.Equals("")) {
                txbDescription.Text = "Dette felt skal have en værdig";
                txbDescription.BackColor = Color.Red;
            }
            else if (txbMaxClearTime.Text.Equals("")) {
                txbMaxClearTime.Text = "";
                txbMaxClearTime.BackColor = Color.Red;
            }
            else if (txbCleanTime.Text.Equals("")) {
                txbCleanTime.Text = "";
                txbCleanTime.BackColor = Color.Red;
            }
            else if (txbPrice.Text.Equals("")) {
                txbPrice.Text = "";
                txbPrice.BackColor = Color.Red;
            }
            else {
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
        }

        /// <summary>
        /// Checks if there are only numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbPrice_TextChanged(object sender, EventArgs e) {
            try {
                decimal.Parse(txbPrice.Text);
            }
            catch(FormatException FE) {
                txbPrice.Text = "";
                //lblErrorPrice.Visible = true;
            }
        }

        /// <summary>
        /// Checks if there are only numbers, if not then show error label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbMaxClearTime_TextChanged(object sender, EventArgs e) {
            try {
                decimal.Parse(txbMaxClearTime.Text);
            }
            catch (FormatException FE) {
                txbMaxClearTime.Text = "";
                lblErrorClearTime.Visible = true;
            }
        }

        /// <summary>
        /// Checks if there is only numbers, if not then show error label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbCleanTime_TextChanged(object sender, EventArgs e) {
            try {
                decimal.Parse(txbCleanTime.Text);
            }
            catch (FormatException FE) {
                txbCleanTime.Text = "";
                lblErrorCleanTime.Visible = true;
            }
        }

        /// <summary>
        /// Runs ErCtr.Delete with the choosen escaperooms id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = ER.EscapeRoomID;
            ERctr.Delete(id);

            
        }

        /// <summary>
        /// The botton click on find picture, opens a dialog where you can find local pictures, then it set it on the escaperoom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
