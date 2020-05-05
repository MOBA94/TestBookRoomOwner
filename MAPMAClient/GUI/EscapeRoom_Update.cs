using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAPMAClient.Controller;
using MAPMAClient.Model;

namespace MAPMAClient.GUI {
    public partial class EscapeRoom_Update : Form {

        private EscapeRoomCtr ERCtr;
        private EmployeeCtr EmpCtr;
        private List<EscapeRoom> escapeRooms;
        private List<Employee> employees;
        private Employee emp;

        public EscapeRoom_Update(Employee employee) {
            InitializeComponent();
            ERCtr = new EscapeRoomCtr();
            EmpCtr = new EmployeeCtr();
            escapeRooms = new List<EscapeRoom>();
            employees = new List<Employee>();
            FillCobEmpID();
            FillCobEscaperoomID();


        }

        private void FillCobEscaperoomID() 
        {
            escapeRooms = ERCtr.GetAllForOwner();
            cobErID.Items.Clear();

            foreach (EscapeRoom er in escapeRooms) {
                cobErID.Items.Add(er.Name);
            }


        }

        private void FillCobEmpID() {
            employees = EmpCtr.GetAll();
            cobEmpID.Items.Clear();

            foreach (Employee emp in employees) {
                cobEmpID.Items.Add(emp.FirstName + emp.LastName);
            }
        }


        // metoden mangler at fylde comboboxen
        private void FillEmpInfo(Employee employee) {
            //eployee number combobox
            lblShowfName.Text = emp.FirstName;
            lblShowLname.Text = emp.LastName;
            lblShowMail.Text = emp.Mail;
            lblShowPhone.Text = emp.Phone;
            string zc = Convert.ToString(emp.Zipcode);
            lblShowZipcoe.Text = zc;
        }
   
    }
}
