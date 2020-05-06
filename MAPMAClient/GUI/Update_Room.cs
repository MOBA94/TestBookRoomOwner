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
                cobEmployeeName.Items.Add(emp.FirstName + emp.LastName);
            }
            //cobEmployeeName.SelectionStart = employees.IndexOf(ER.Emp);
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
            string name = employees.ElementAt(i).FirstName + employees.ElementAt(i).LastName;

            while (i < employees.Count && !found) {
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
            ERctr.UpdateEscapeRoom(name, description, maxClearTime, cleanTime, price, rating, empID);
            this.Hide();
            CreateEscapeRoom cer = new CreateEscapeRoom();
            cer.Show();
        }
    }
}
