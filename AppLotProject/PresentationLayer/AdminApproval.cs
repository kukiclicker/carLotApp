using BusinessLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AdminApproval : Form
    {
        public static IEmployeeBusiness employeeBusiness;
        public List<Employee> employees;
        public Employee newEmployee;
        public AdminApproval(Employee newEmployee,IEmployeeBusiness _employeeBusiness)
        {

            InitializeComponent();
            this.newEmployee = newEmployee;
            employeeBusiness = _employeeBusiness;
            employees = employeeBusiness.GetAllEmployees();
        }
        private void buttonConfirm_MouseClick(object sender, MouseEventArgs e)
        {
            Employee admin = (Employee)employees.Where(x => x.UserName == textBoxUsername.Text).FirstOrDefault();
            if (admin == null)
            {
                MessageBox.Show("User doesnt exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (admin.Password == textBoxPassword.Text && admin.Role.ToLower() =="admin"|| admin.Role.ToLower() == "administrator")
            {
                employeeBusiness.InsertEmployee(newEmployee);
                MessageBox.Show("New employee added successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Either user is not admin or you have entered a wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
